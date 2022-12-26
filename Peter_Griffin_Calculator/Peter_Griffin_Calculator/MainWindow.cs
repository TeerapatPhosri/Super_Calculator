// นาย ธีรภัทร โพธิ์ศรี รหัส 653450289-3
// วิชา OOP

using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    float num;
    float num1 = 0;
    float num2 = 0;
    float re; //result
    bool F = false;
    bool S = false;
    int operation;
    char operate;
    bool point = false; //ทศนิยม
    float D = 1; // div10
    int I;
    int L = 1;
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnOneClickClicked(object sender, EventArgs e)
    {

        num = 1;
        if (!S)
        {
            if (!F)
            {
                if (!point)
                {
                    num1 = num;
                    F = true;
                } else
                {
                    //L++; // notice D first, then ++ //d = d+1for
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = D * num;
                    Console.WriteLine(num1 + " " + D);
                    F = true;
                }
            }
            else
            {
                if (!point)
                {
                    num1 = (num1 * 10) + num;
                }
                else
                {
                    Console.WriteLine(D);
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = num1 + (D * num);
                }
            }
            this.monitor.Text = Convert.ToString(num1);
            this.monitor2.Text = Convert.ToString(num1);
        } //end of num1

        else if (!F)
        {
            if (!point)
            {
                num2 = num;
                F = true;
                }else
            {
                L++; 
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = D * num;
                Console.WriteLine(num1 + " " + D);
                F = true;
            }
        }
        else
        {
            if (!point)
            {
                num2 = (num2 * 10) + num;
            }
            else
            {
                Console.WriteLine(" ");
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = num2 + (D * num);
            }
            this.monitor.Text = Convert.ToString(num2);
            this.monitor2.Text = Convert.ToString(num1) + " " + operate + " " + Convert.ToString(num2);
            //end of num2
        }

    }
    protected void OnTwoClickClicked(object sender, EventArgs e)
       {
        num = 2;
        if (!S)
        {
            if (!F)
            {
                if (!point)
                {
                    num1 = num;
                    F = true;
                }
                else
                {
                    //L++; // notice D first, then ++ //d = d+1for
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = D * num;
                    Console.WriteLine(num1 + " " + D);
                    F = true;
                }
            }
            else
            {
                if (!point)
                {
                    num1 = (num1 * 10) + num;
                }
                else
                {
                    Console.WriteLine(D);
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = num1 + (D * num);
                }
            }
            this.monitor.Text = Convert.ToString(num1);
            this.monitor2.Text = Convert.ToString(num1);
        } //end of num1

        else if (!F)
        {
            if (!point)
            {
                num2 = num;
                F = true;
            }
            else
            {
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = D * num;
                Console.WriteLine(num1 + " " + D);
                F = true;
            }
        }
        else
        {
            if (!point)
            {
                num2 = (num2 * 10) + num;
            }
            else
            {
                Console.WriteLine(" ");
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = num2 + (D * num);
            }
            this.monitor.Text = Convert.ToString(num2);
            this.monitor2.Text = Convert.ToString(num1) + " " + operate + " " + Convert.ToString(num2);
            //end of num2
        }
    }


    protected void OnThreeClickClicked(object sender, EventArgs e)
    {
        num = 3;
        if (!S)
        {
            if (!F)
            {
                if (!point)
                {
                    num1 = num;
                    F = true;
                }
                else
                {
                    //L++; // notice D first, then ++ //d = d+1for
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = D * num;
                    Console.WriteLine(num1 + " " + D);
                    F = true;
                }
            }
            else
            {
                if (!point)
                {
                    num1 = (num1 * 10) + num;
                }
                else
                {
                    Console.WriteLine(D);
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = num1 + (D * num);
                }
            }
            this.monitor.Text = Convert.ToString(num1);
            this.monitor2.Text = Convert.ToString(num1);
        } //end of num1

        else if (!F)
        {
            if (!point)
            {
                num2 = num;
                F = true;
            }
            else
            {
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = D * num;
                Console.WriteLine(num1 + " " + D);
                F = true;
            }
        }
        else
        {
            if (!point)
            {
                num2 = (num2 * 10) + num;
            }
            else
            {
                Console.WriteLine(" ");
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = num2 + (D * num);
            }
            this.monitor.Text = Convert.ToString(num2);
            this.monitor2.Text = Convert.ToString(num1) + " " + operate + " " + Convert.ToString(num2);
            //end of num2
        }
    }

    protected void OnFourClickClicked(object sender, EventArgs e)
    {
        num = 4;
        if (!S)
        {
            if (!F)
            {
                if (!point)
                {
                    num1 = num;
                    F = true;
                }
                else
                {
                    //L++; // notice D first, then ++ //d = d+1for
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = D * num;
                    Console.WriteLine(num1 + " " + D);
                    F = true;
                }
            }
            else
            {
                if (!point)
                {
                    num1 = (num1 * 10) + num;
                }
                else
                {
                    Console.WriteLine(D);
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = num1 + (D * num);
                }
            }
            this.monitor.Text = Convert.ToString(num1);
            this.monitor2.Text = Convert.ToString(num1);
        } //end of num1

        else if (!F)
        {
            if (!point)
            {
                num2 = num;
                F = true;
            }
            else
            {
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = D * num;
                Console.WriteLine(num1 + " " + D);
                F = true;
            }
        }
        else
        {
            if (!point)
            {
                num2 = (num2 * 10) + num;
            }
            else
            {
                Console.WriteLine(" ");
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = num2 + (D * num);
            }
            this.monitor.Text = Convert.ToString(num2);
            this.monitor2.Text = Convert.ToString(num1) + " " + operate + " " + Convert.ToString(num2);
            //end of num2
        }
    }

    protected void OnFiveClickClicked(object sender, EventArgs e)
    {
        num = 5;
        if (!S)
        {
            if (!F)
            {
                if (!point)
                {
                    num1 = num;
                    F = true;
                }
                else
                {
                    //L++; // notice D first, then ++ //d = d+1for
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = D * num;
                    Console.WriteLine(num1 + " " + D);
                    F = true;
                }
            }
            else
            {
                if (!point)
                {
                    num1 = (num1 * 10) + num;
                }
                else
                {
                    Console.WriteLine(D);
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = num1 + (D * num);
                }
            }
            this.monitor.Text = Convert.ToString(num1);
            this.monitor2.Text = Convert.ToString(num1);
        } //end of num1

        else if (!F)
        {
            if (!point)
            {
                num2 = num;
                F = true;
            }
            else
            {
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = D * num;
                Console.WriteLine(num1 + " " + D);
                F = true;
            }
        }
        else
        {
            if (!point)
            {
                num2 = (num2 * 10) + num;
            }
            else
            {
                Console.WriteLine(" ");
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = num2 + (D * num);
            }
            this.monitor.Text = Convert.ToString(num2);
            this.monitor2.Text = Convert.ToString(num1) + " " + operate + " " + Convert.ToString(num2);
            //end of num2
        }
    }

    protected void OnSixClickClicked(object sender, EventArgs e)
    {
        num = 6;
        if (!S)
        {
            if (!F)
            {
                if (!point)
                {
                    num1 = num;
                    F = true;
                }
                else
                {
                    //L++; // notice D first, then ++ //d = d+1for
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = D * num;
                    Console.WriteLine(num1 + " " + D);
                    F = true;
                }
            }
            else
            {
                if (!point)
                {
                    num1 = (num1 * 10) + num;
                }
                else
                {
                    Console.WriteLine(D);
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = num1 + (D * num);
                }
            }
            this.monitor.Text = Convert.ToString(num1);
            this.monitor2.Text = Convert.ToString(num1);
        } //end of num1

        else if (!F)
        {
            if (!point)
            {
                num2 = num;
                F = true;
            }
            else
            {
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = D * num;
                Console.WriteLine(num1 + " " + D);
                F = true;
            }
        }
        else
        {
            if (!point)
            {
                num2 = (num2 * 10) + num;
            }
            else
            {
                Console.WriteLine(" ");
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = num2 + (D * num);
            }
            this.monitor.Text = Convert.ToString(num2);
            this.monitor2.Text = Convert.ToString(num1) + " " + operate + " " + Convert.ToString(num2);
            //end of num2
        }
    }

    protected void OnSevenClickClicked(object sender, EventArgs e)
    {
        num = 7;
        if (!S)
        {
            if (!F)
            {
                if (!point)
                {
                    num1 = num;
                    F = true;
                }
                else
                {
                    //L++; // notice D first, then ++ //d = d+1for
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = D * num;
                    Console.WriteLine(num1 + " " + D);
                    F = true;
                }
            }
            else
            {
                if (!point)
                {
                    num1 = (num1 * 10) + num;
                }
                else
                {
                    Console.WriteLine(D);
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = num1 + (D * num);
                }
            }
            this.monitor.Text = Convert.ToString(num1);
            this.monitor2.Text = Convert.ToString(num1);
        } //end of num1

        else if (!F)
        {
            if (!point)
            {
                num2 = num;
                F = true;
            }
            else
            {
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = D * num;
                Console.WriteLine(num1 + " " + D);
                F = true;
            }
        }
        else
        {
            if (!point)
            {
                num2 = (num2 * 10) + num;
            }
            else
            {
                Console.WriteLine(" ");
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = num2 + (D * num);
            }
            this.monitor.Text = Convert.ToString(num2);
            this.monitor2.Text = Convert.ToString(num1) + " " + operate + " " + Convert.ToString(num2);
            //end of num2
        }
    }

    protected void OnEightClickClicked(object sender, EventArgs e)
    {
        num = 8;
        if (!S)
        {
            if (!F)
            {
                if (!point)
                {
                    num1 = num;
                    F = true;
                }
                else
                {
                    //L++; // notice D first, then ++ //d = d+1for
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = D * num;
                    Console.WriteLine(num1 + " " + D);
                    F = true;
                }
            }
            else
            {
                if (!point)
                {
                    num1 = (num1 * 10) + num;
                }
                else
                {
                    Console.WriteLine(D);
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = num1 + (D * num);
                }
            }
            this.monitor.Text = Convert.ToString(num1);
            this.monitor2.Text = Convert.ToString(num1);
        } //end of num1

        else if (!F)
        {
            if (!point)
            {
                num2 = num;
                F = true;
            }
            else
            {
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = D * num;
                Console.WriteLine(num1 + " " + D);
                F = true;
            }
        }
        else
        {
            if (!point)
            {
                num2 = (num2 * 10) + num;
            }
            else
            {
                Console.WriteLine(" ");
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = num2 + (D * num);
            }
            this.monitor.Text = Convert.ToString(num2);
            this.monitor2.Text = Convert.ToString(num1) + " " + operate + " " + Convert.ToString(num2);
            //end of num2
        }
    }

    protected void OnNineClickClicked(object sender, EventArgs e)
    {
        num = 9;
        if (!S)
        {
            if (!F)
            {
                if (!point)
                {
                    num1 = num;
                    F = true;
                }
                else
                {
                    //L++; // notice D first, then ++ //d = d+1for
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = D * num;
                    Console.WriteLine(num1 + " " + D);
                    F = true;
                }
            }
            else
            {
                if (!point)
                {
                    num1 = (num1 * 10) + num;
                }
                else
                {
                    Console.WriteLine(D);
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = num1 + (D * num);
                }
            }
            this.monitor.Text = Convert.ToString(num1);
            this.monitor2.Text = Convert.ToString(num1);
        } //end of num1

        else if (!F)
        {
            if (!point)
            {
                num2 = num;
                F = true;
            }
            else
            {
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = D * num;
                Console.WriteLine(num1 + " " + D);
                F = true;
            }
        }
        else
        {
            if (!point)
            {
                num2 = (num2 * 10) + num;
            }
            else
            {
                Console.WriteLine(" ");
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = num2 + (D * num);
            }
            this.monitor.Text = Convert.ToString(num2);
            this.monitor2.Text = Convert.ToString(num1) + " " + operate + " " + Convert.ToString(num2);
            //end of num2
        }
    }

    protected void OnZeroClickClicked(object sender, EventArgs e)
    {
        num = 0;
        if (!S)
        {
            if (!F)
            {
                if (!point)
                {
                    num1 = num;
                    F = true;
                }
                else
                {
                    //L++; // notice D first, then ++ //d = d+1for
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = D * num;
                    Console.WriteLine(num1 + " " + D);
                    F = true;
                }
            }
            else
            {
                if (!point)
                {
                    num1 = (num1 * 10) + num;
                }
                else
                {
                    Console.WriteLine(D);
                    for (I = 0; I < L; I++)
                    {
                        D = D / 10;
                    }
                    num1 = num1 + (D * num);
                }
            }
            this.monitor.Text = Convert.ToString(num1);
            this.monitor2.Text = Convert.ToString(num1);
        } //end of num1

        else if (!F)
        {
            if (!point)
            {
                num2 = num;
                F = true;
            }
            else
            {
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = D * num;
                Console.WriteLine(num1 + " " + D);
                F = true;
            }
        }
        else
        {
            if (!point)
            {
                num2 = (num2 * 10) + num;
            }
            else
            {
                Console.WriteLine(" ");
                L++;
                for (I = 0; I < L; I++)
                {
                    D = D / 10;
                }
                num2 = num2 + (D * num);
            }
            this.monitor.Text = Convert.ToString(num2);
            this.monitor2.Text = Convert.ToString(num1) + " " + operate + " " + Convert.ToString(num2);
            //end of num2
        }
    }

    protected void OnPlusClickClicked(object sender, EventArgs e)
    {
        operation = 1;
        operate = '+';
        S = true;
        D = 1;
        point = false;
        L = 0;
        this.monitor.Text = " ";
        this.monitor2.Text = Convert.ToString(num1) + " " + operate;
    }

    protected void OnMinusClickClicked(object sender, EventArgs e)
    {
        operation = 2;
        operate = '-';
        S = true;
        this.monitor.Text = " ";
        this.monitor2.Text = Convert.ToString(num1) + " " + operate;
    }

    protected void OnMultiplyClickClicked(object sender, EventArgs e)
    {
        operation = 3;
        operate = '*';
        S = true;
        this.monitor.Text = " ";
        this.monitor2.Text = Convert.ToString(num1) + " " + operate;
    }

    protected void OnDivideClickClicked(object sender, EventArgs e)
    {
        operation = 4;
        operate = '/';
        S = true;
        this.monitor.Text = " ";
        this.monitor2.Text = Convert.ToString(num1) + " " + operate;
    }

    protected void OnPointClickClicked(object sender, EventArgs e)
    {
        point = true;
        if (!S)
        {
            this.monitor2.Text = Convert.ToString(num1) + " " + operate + " " + Convert.ToString(num2) + ".";
            point = true;
        }
        else this.monitor2.Text = Convert.ToString(num1) + ".";

    }

    //protected void OnNegativeClickClicked(object sender, EventArgs e) //ตัวนี้บัคเยอะ
    //{
      //  if (!S)
      //  {
      //      num1 = num1 * (-1);
      //      this.monitor.Text = Convert.ToString(num1);
       //     this.monitor2.Text = Convert.ToString(num1);
      //  }
       // else num2 = num2 * (-1);
       // {
       //     this.monitor.Text = Convert.ToString(num2);
       //     this.monitor2.Text = Convert.ToString(num1) + " " + operate + " " + Convert.ToString(num2);
       // }
   // }

    protected void OnClearClickClicked(object sender, EventArgs e)
    {
        num1 = 0;
        num2 = 0;
        F = false;
        S = false;
        D = 1;
        point = false;
        L = 0;
        this.monitor.Text = " ";
        this.monitor2.Text = " ";
    }

    protected void OnResultClickClicked(object sender, EventArgs e)
    {
        switch (operation)
        {
            case 1:
                re = num1 + num2;
                break;
            case 2:
                re = num1 - num2;
                break;
            case 3:
                re = num1 * num2;
                break;
            case 4:
                re = num1 / num2;
                break;
        }
        this.monitor.Text = ""+re.ToString("N");
        this.monitor2.Text = Convert.ToString(num1) + " " + operate + " " + Convert.ToString(num2) + " " + "=" + " " + re.ToString("N");
    }
    // สถานะแอพลิเคชัน สามารถบวกลบคูณหารได้ปกติ สามารถเคลียร์หน้าจอได้ มีคอมม่าขั้น มีหน้าจอคำนวณรองและหลัก
    // ปัญหา สามารถคำนวณทศนิยมได้ครั้งเดียว ครั้งแรกหลังจากเปิดแอพพลิเคชัน เมื่อเกิดการคำนวณแล้ว พอกดปุ่มทศนิยมจะมีบัค
}
