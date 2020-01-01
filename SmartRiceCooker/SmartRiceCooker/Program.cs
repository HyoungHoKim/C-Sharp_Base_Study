using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SmartRiceCooker
{

    public enum CookerProcess { None, Riceing, Watering, Washing, Droping, Cooking, Completion, Keeping }

    struct RiceCookerInfo
    {
        public bool CoverOpenClose;
        public bool Power;
        public CookerProcess State;
        public int Rice;
        public int Water;
        public int Number;

        public RiceCookerInfo(int rice, int water)
        {
            this.CoverOpenClose = false;
            this.Power = false;
            this.State = CookerProcess.None;
            this.Rice = rice;
            this.Water = water;
            this.Number = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(99, 36);
            RiceCookerInfo RCInfo = new RiceCookerInfo(10000, 5000);
            string[] MenuItem = { "   전원   ", "   뚜껑   ", "   취사   ", "   보온   ", "   취소   ", "  인원수  ", "    쌀    ", "    물    " };

            Menu menu = new Menu(65, 25, MenuItem);
            RiceBox mRiceBox = new RiceBox(16, 11);
            MessageBox mMessageBox = new MessageBox(51, 27);
            WaterHeight mWaterHeight = new WaterHeight(74, 2, RCInfo.Water);
            RiceHeight mRiceHeight = new RiceHeight(50, 2, RCInfo.Rice);

            while (true)
            {
                OutFrame();
                mRiceBox.showBox();
                Cover(RCInfo.CoverOpenClose);
                RiceInfo(RCInfo);
                PowerLine(RCInfo.Power);

                menu.showMenu();
                if (menu.MainMenuIndex == 9) break;

                switch (menu.MainMenuIndex)
                {
                    case 0:
                        RCInfo.Power = !RCInfo.Power;
                        break;
                    case 1:
                        if(RCInfo.State == CookerProcess.Cooking)
                        {
                            mMessageBox.showBox("취사 중일 때는 뚜껑을 열 수 없습니다.");
                            Console.ReadKey(true);
                        }
                        else
                        {
                            RCInfo.CoverOpenClose = !RCInfo.CoverOpenClose;                       
                        }
                        break;
                    case 2:
                        if (!RCInfo.Power)
                        {
                            mMessageBox.showBox("전원이 꺼져있습니다.");
                            Console.ReadKey(true);
                            break;
                        }

                        if (RCInfo.CoverOpenClose)
                        {
                            mMessageBox.showBox("뚜껑이 열려져 있습니다.");
                            Console.ReadKey(true);
                            break;
                        }

                        if(RCInfo.Number == 0)
                        {
                            mMessageBox.showBox("인원 수 입력 : ");
                            RCInfo.Number = int.Parse(Console.ReadLine());
                        }

                        int Rice = RCInfo.Rice - (RCInfo.Number * 160);
                        if(Rice < 0)
                        {
                            mMessageBox.showBox("  ??? 쌀 부족 ???");
                            Console.ReadKey(true);
                            break;
                        }

                        int Water;
                        Water = RCInfo.Water - (RCInfo.Number * 170) * 5;
                        if(Water < 0)
                        {
                            mMessageBox.showBox("  ??? 물 부족 ???");
                            Console.ReadKey(true);
                            break;
                        }

                        

                        RCInfo.State = CookerProcess.Riceing;
                        RiceInfo(RCInfo);

                        Console.SetCursorPosition(24, 12);
                        Console.Write("쌀 넣기");
                        Console.SetCursorPosition(18, 13);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 14);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 15);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 16);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 17);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        RCInfo.Rice = RCInfo.Rice - (RCInfo.Number * 160);
                        mRiceHeight.showBox();
                        Thread.Sleep(3000);

                        for(int i = 0; i < 2; i++)
                        {
                            RCInfo.State = CookerProcess.Watering;
                            RCInfo.Water = RCInfo.Water - (RCInfo.Number * 170 * 2);
                            RiceInfo(RCInfo);

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(24, 12);
                            Console.Write("물 넣기");
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(18, 13);
                            Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                            Console.SetCursorPosition(18, 14);
                            Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                            Console.SetCursorPosition(18, 15);
                            Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                            Console.SetCursorPosition(18, 16);
                            Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                            Console.SetCursorPosition(18, 17);
                            Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                            mWaterHeight.showBox(RCInfo.Water);
                            Thread.Sleep(3000);

                            RCInfo.State = CookerProcess.Washing;
                            RiceInfo(RCInfo);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(24, 12);
                            Console.Write("쌀 씻기");
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(18, 13);
                            Console.Write("~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
                            Console.SetCursorPosition(18, 14);
                            Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                            Console.SetCursorPosition(18, 15);
                            Console.Write("~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
                            Console.SetCursorPosition(18, 16);
                            Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                            Console.SetCursorPosition(18, 17);
                            Console.Write("~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
                            Thread.Sleep(3000);


                            RCInfo.State = CookerProcess.Droping;
                            RiceInfo(RCInfo);

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(24, 12);
                            Console.Write(" 배수 ");
                            for(int j = 0; j < 5; j++)
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                for(int k = 0; k < j; k++)
                                {
                                    Console.SetCursorPosition(18, 13 + k);
                                    Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                                }

                                Console.BackgroundColor = ConsoleColor.Blue;
                                for (int k = 0; k < 5; k++)
                                {
                                    Console.SetCursorPosition(18, 13 + k);
                                    Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                                }
                                Thread.Sleep(700);
                            }
                        }

                        // 취사용 물 공급 
                        RCInfo.Water = RCInfo.Water - (RCInfo.Number * 170);
                        mWaterHeight.showBox(RCInfo.Water);
                        RiceInfo(RCInfo);

                        // 취사 시작
                        RCInfo.State = CookerProcess.Cooking;
                        RiceInfo(RCInfo);

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(24, 12);
                        Console.Write("취사 중");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(18, 13);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 14);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 15);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 16);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 17);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Thread.Sleep(7000);

                        RCInfo.State = CookerProcess.Completion;
                        RiceInfo(RCInfo);
                        Thread.Sleep(7000);

                        Console.Write("취사 완료");
                        Thread.Sleep(3000);

                        RCInfo.State = CookerProcess.Keeping;
                        RiceInfo(RCInfo);

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(24, 12);
                        Console.Write("보온 중  ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(18, 13);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 14);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 15);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 16);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 17);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Thread.Sleep(3000);
                        Console.ForegroundColor = ConsoleColor.White;

                        RCInfo.Number = 0;
                        break;

                    case 3: // 보온
                        if(!RCInfo.Power)
                        {
                            mMessageBox.showBox("전원이 꺼져있습니다");
                            Console.ReadKey(true);
                            break;
                        }

                        RCInfo.State = CookerProcess.Keeping;
                        RiceInfo(RCInfo);

                        break;
                }
            }
            
        }

        static void Cover(bool bOpen)
        {
            const int x = 16;
            if (bOpen)
            {
                Console.SetCursorPosition(x, 2);
                Console.Write("┌┐");
                for(int i = 0; i < 7; i++)
                {
                    Console.SetCursorPosition(x, 3 + i);
                    Console.Write("││");            
                }
                Console.SetCursorPosition(x, 10);
                Console.Write("└┘");
            }
            else
            {
                Console.SetCursorPosition(x, 9);
                Console.Write("┌──────────┐");
                Console.SetCursorPosition(x, 10);
                Console.Write("└──────────┘");
            }
        }

        static void RiceInfo(RiceCookerInfo Info)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(3, 25);
            if (Info.Power)
                Console.Write("전원 상태 : ON");
            else
                Console.Write("전원 상태 : OFF");

            Console.SetCursorPosition(3, 26);
            if (Info.CoverOpenClose)
                Console.Write("뚜껑 상태 : 열림");
            else
                Console.Write("뚜껑 상태 : 닫힘");

            Console.SetCursorPosition(3, 27);
            switch (Info.State)
            {
                case CookerProcess.None:
                    Console.Write("밥솥 상태 : 대기 중  ");
                    break;
                case CookerProcess.Riceing:
                    Console.Write("밥솥 상태 : 밥 넣기  ");
                    break;
                case CookerProcess.Watering:
                    Console.Write("밥솥 상태 : 물 넣기  ");
                    break;
                case CookerProcess.Washing:
                    Console.Write("밥솥 상태 : 쌀 씻기  ");
                    break;
                case CookerProcess.Droping:
                    Console.Write("밥솥 상태 : 물 배수  ");
                    break;
                case CookerProcess.Cooking:
                    Console.Write("밥솥 상태 : 취사 중  ");
                    break;
                case CookerProcess.Completion:
                    Console.Write("밥솥 상태 : 취사  완료");
                    break;
                case CookerProcess.Keeping:
                    Console.Write("밥솥 상태 : 보온 중  ");
                    break;

            }

            Console.SetCursorPosition(3, 28);
            Console.Write("인원수 : {0}", Info.Number);
            Console.SetCursorPosition(3, 29);
            Console.Write("쌀 상태 : {0:f1} Kg", Info.Rice / 1000.0f);
            Console.SetCursorPosition(3, 30);
            Console.Write("물 상태 : {0:f1} 리터", Info.Water / 1000.0f);
        }

        static void OutFrame()
        {
            RiceCookerBox mRiceCookerBox = new RiceCookerBox(0, 0);
            mRiceCookerBox.showBox();

            RiceOrWaterBox mRiceOrWateBox = new RiceOrWaterBox(48, 0);
            mRiceOrWateBox.showBox();
            RiceOrWaterBox mRiceOrWateBox2 = new RiceOrWaterBox(72, 0);
            mRiceOrWateBox2.showBox();

            InfoOrMenuBox mInfoOrMenuBox = new InfoOrMenuBox(0, 21);
            mInfoOrMenuBox.showBox();
            InfoOrMenuBox mInfoOrMenuBox2 = new InfoOrMenuBox(48, 21);
            mInfoOrMenuBox.showBox();

            Console.SetCursorPosition(17, 1);
            Console.Write("Smart 밥솥");
            Console.SetCursorPosition(58, 1);
            Console.Write("쌀통");
            Console.SetCursorPosition(82, 1);
            Console.Write("물통");
            Console.SetCursorPosition(18, 23);
            Console.Write("밥솥 정보");
            Console.SetCursorPosition(66, 23);
            Console.Write("(( 메뉴 ))");
        }


    }

  
}
