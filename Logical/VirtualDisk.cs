using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManageSystem
{
    public class VirtualDisk
    {
        public int size;
        public int blockSize;
        public int blockNum;
        public string[] memory = new string[] { };
        public int[] bitMap = new int[] { };
        public int remain;
        public VirtualDisk(int s, int bs)
        {
            size = s;
            blockSize = bs;
            blockNum = s / blockSize;
            if (s % blockSize != 0)
                blockNum++;
            remain = blockNum;
            memory = new string[blockNum];    //申请内存空间
            bitMap = new int[blockNum];     //位图表
            //初始化位图表,-1表示当前块可用,其他块表示为接下来的链接,-2表示结束
            for (int i = 0; i < blockNum; i++)
            {
                bitMap[i] = -1;
            }
            for (int i = 0; i < blockNum; i++)
                memory[i] = "";
        }

        //给文件分配盘块
        public bool giveSpace(FCB fcb, string content)
        {
            int blocks = fcb.size / blockSize;     //文件所占的空间的大小
            if (fcb.size % blockSize != 0)
                blocks++;
            if (blocks <= remain)
            {
                int start = 0;  //文件开始存放的块的位置

                for (int i = 0; i < blockNum; i++)  //文件开始存放的位置
                {
                    if (bitMap[i] == -1)
                    {
                        remain--;
                        start = i;
                        fcb.start = i;
                        memory[i] = content.Substring(0, blockSize);
                        break;
                    }
                }
                for (int j = 1, i = start + 1; j < blocks && i < blockNum; i++)
                {
                    if (bitMap[i] == -1)
                    {
                        remain--;
                        bitMap[start] = i;
                        start = i;
                        if (blocks != 1)
                        {
                            if (j != blocks - 1)
                                memory[i] = content.Substring(j * blockSize, blockSize);
                            else
                            {
                                bitMap[i] = -2;   //文件最后一块
                                if (fcb.size % blockSize != 0)
                                    memory[i] = content.Substring(j * blockSize, content.Length - j * blockSize);
                                else
                                    memory[i] = content.Substring(j * blockSize, blockSize);
                            }

                        }
                        else
                            memory[i] = content;
                        j++;   //找到一个位置
                    }
                }
                return true;
            }
            else
                return false;

        }

        //把内容找出来
        public string  getFileContent(FCB fcb)
        {
            if(fcb.start!=-1)//文件不为空
            {
                string content = "";
                int start = fcb.start;
                int blocks = fcb.size / blockSize;
                if (fcb.size % blockSize != 0)
                    blocks++;
                int count = 0;
                for (int i = start; i < blockNum;)
                {
                    if (count == blocks)
                    {
                        break;
                    }
                    else
                    {
                        content = content + memory[i];
                        i = bitMap[i];
                        count++;
                    }

                }
                return content;
            }
            return "";
        }

        //把内容删掉
        public void deleteFileContent(int start,int size)
        {
            
            int blocks = size / blockSize;
            if (size % blockSize != 0)
                blocks++;
            int count = 0;
            for (int i = start; i < blockNum;)
            {
                if (count == blocks)
                {
                    break;
                }
                else
                {
                    memory[i] = "";
                    remain++;
                    int temp = bitMap[i];
                    bitMap[i] = -1;
                    i = temp;
                    count++;
                }

            }
        }
        //内容更新
        public void fileUpdate(int oldStart,int oldSize, FCB newFcb, string newContent)
        {
            deleteFileContent(oldStart, oldSize);
            giveSpace(newFcb, newContent);
        }
    }
}
