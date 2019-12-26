using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteRead
{
    class Program
    {
        private struct GRADE
        {
            public int kor, eng, math, total;
            public float aver;
        }

        static void Main(string[] args)
        { 
            int nCount;

            Console.Write("학생 수를 입력해주세요 : ");
            nCount = int.Parse(Console.ReadLine());

            GRADE[] stu = new GRADE[nCount];
           
            
            FileStream fs = new FileStream("text.txt");
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("학생 수 : {0}", nCount);

            for(int i = 0; i < nCount; i++)
            {
                string score;
                score = Console.ReadLine();

                string[] sScore =score.Split(new char[] { ',' });
                stu[i].kor = int.Parse(sScore[0]);
                stu[i].eng = int.Parse(sScore[1]);
                stu[i].math = int.Parse(sScore[2]);
                stu[i].total = stu[i].kor + stu[i].eng + stu[i].math;
                stu[i].aver = stu[i].total / 3.0f;

                sw.WriteLine("{0}, {1}, {2}, {3}, {4}", stu[i].kor, stu[i].eng, stu[i].math, stu[i].total, stu[i].aver);
            }
            
            sw.Close();

        }
    }
}
