using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tic_tac_toe
{
public partial class Form1 : Form

    {

        //Инициализация программы:

        int mark = 0, markPC = 0, Vuser = 0, Vpc = 0;
        int[] field;
        int index = 0;
        bool Enable = false;
        bool first = true;

        public  Form1()
        {
            InitializeComponent();
            ClearField();
            field = new int[9];
        }

        //События меню программы:

        private void btnExit_Click(object sender, EventArgs e)

        {

            Application.Exit();

        }

        private void btnNewKrestik_Click(object sender, EventArgs e)

        {

            // Пользователь выбрал крестик, компьютеру достался нолик

            mark = 2;

            markPC = 1;

            first = true;

            NewGame();

        }

        private void btnNewNull_Click(object sender, EventArgs e)

        {

            // Пользователь выбрал нолик, компьютеру достался крестик и право первого хода

            mark = 1;

            markPC = 2;

            first = false;

            NewGame();

        }


        private void lbStep_Click(object sender, EventArgs e)
        {
            NewGame();
            ClearField();

        
        }

        //Метод активации поля:

        void Enabledfield()

        {

            btn00.Enabled = Enable;

            btn01.Enabled = Enable;

            btn02.Enabled = Enable;

            btn10.Enabled = Enable;

            btn11.Enabled = Enable;

            btn12.Enabled = Enable;

            btn20.Enabled = Enable;

            btn21.Enabled = Enable;

            btn22.Enabled = Enable;

        }

        //Метод очистки поля:

        void ClearField()

        {

            btn00.Text = "";

            btn01.Text = "";

            btn02.Text = "";

            btn10.Text = "";

            btn11.Text = "";

            btn12.Text = "";

            btn20.Text = "";

            btn21.Text = "";

            btn22.Text = "";

        }

        //Метод обновления поля после хода компьютера:

        void UpdateField()

        {

            switch (index)

            {

                case 0:
                    if (markPC == 2) btn00.Text = "X"; else if (markPC == 1) btn00.Text = "O";

                    btn00.Enabled = false;

                    break;

                case 1:
                    if (markPC == 2) btn01.Text = "X"; else if (markPC == 1) btn01.Text = "O";

                    btn01.Enabled = false;

                    break;

                case 2:
                    if (markPC == 2) btn02.Text = "X"; else if (markPC == 1) btn02.Text = "O";

                    btn02.Enabled = false;

                    break;

                case 3:
                    if (markPC == 2) btn10.Text = "X"; else if (markPC == 1) btn10.Text = "O";

                    btn10.Enabled = false;

                    break;

                case 4:
                    if (markPC == 2) btn11.Text = "X"; else if (markPC == 1) btn11.Text = "O";

                    btn11.Enabled = false;

                    break;

                case 5:
                    if (markPC == 2) btn12.Text = "X"; else if (markPC == 1) btn12.Text = "O";

                    btn12.Enabled = false;

                    break;

                case 6:
                    if (markPC == 2) btn20.Text = "X"; else if (markPC == 1) btn20.Text = "O";

                    btn20.Enabled = false;

                    break;

                case 7:
                    if (markPC == 2) btn21.Text = "X"; else if (markPC == 1) btn21.Text = "O";

                    btn21.Enabled = false;

                    break;

                case 8:
                    if (markPC == 2) btn22.Text = "X"; else if (markPC == 1) btn22.Text = "O";

                    btn22.Enabled = false;

                    break;

            }

        }

        //Метод начала новой игры:

        void NewGame()

        {

            ClearField();

            lbStep.Text = "New Game";

            for (int i = 0; i < 9; i++) field[i] = 0;

            Enable = true;

            Enabledfield();

            if (!first) PC_principle();

        }

        //Событие ButtonX_Click():

        private void btn00_Click(object sender, EventArgs e)

        {

            index = 0;
            
            if (mark == 2) btn00.Text = "X"; else if (mark == 1)  btn00.Text = "O";

           

            btn00.Enabled = false;

            PC_principle();

        }

        private void btn01_Click(object sender, EventArgs e)

        {

            index = 1;
            
            if (mark == 2) btn01.Text = "X"; else if (mark == 1)   btn01.Text = "O";
            
            btn01.Enabled = false;

            PC_principle();

        }

        private void btn02_Click(object sender, EventArgs e)

        {

            index = 2;
           
            if (mark == 2) btn02.Text = "X"; else if (mark == 1)  btn02.Text = "O";

            

            btn02.Enabled = false;

            PC_principle();

        }

        private void btn10_Click(object sender, EventArgs e)

        {

            index = 3;
            
            if (mark == 2) btn10.Text = "X"; else if (mark == 1)  btn10.Text = "O";

            

            btn10.Enabled = false;

            PC_principle();

        }

        private void btn11_Click(object sender, EventArgs e)

        {

            index = 4;
            
            if (mark == 2) btn11.Text = "X"; else if (mark == 1)  btn11.Text = "O";

            
            btn11.Enabled = false;

            PC_principle();

        }

        private void btn12_Click(object sender, EventArgs e)

        {
            index = 5;
            
            if (mark == 2) btn12.Text = "X"; else if (mark == 1)  btn12.Text = "O";

            
            btn12.Enabled = false;

            PC_principle();

        }

        private void btn20_Click(object sender, EventArgs e)

        {

            index = 6;
            
            if (mark == 2) btn20.Text = "X"; else if (mark == 1)  btn20.Text = "O";

            btn20.Enabled = false;

            PC_principle();

        }

        private void btn21_Click(object sender, EventArgs e)

        {

            index = 7;
            
            if (mark == 2) btn21.Text = "X"; else if (mark == 1)  btn21.Text = "O";
            

            btn21.Enabled = false;

            PC_principle();

        }

        private void btn22_Click(object sender, EventArgs e)

        {

            index = 8;

            if (mark == 2) btn22.Text = "X"; else if (mark == 1) btn22.Text = "O";

            
            btn22.Enabled = false;

            PC_principle();

        }

        //Метод «мозга» игры:

        void PC_principle()

        {

            bool markNull = false, mark_X = false;

            if (first)

            {

                field[index] = mark;

                verification();

            }

            first = true;

            if (Enable)

            {
                ///////////////////// temp это количество пустых клеток
               
                int temp = 0, indexNull = 0;

                bool zero = false, flag = true;

                ////////////////////////////////// Два знака компьютера в ряду

                if (flag)

                {

                    for (int k = 0; k < 3; k++)

                    {

                        zero = false; temp = 0;

                        for (int i = 0; i < 3; i++)

                        {

                            if (field[i + 3 * k] == markPC) temp++;

                            if (field[i + 3 * k] == 0) { zero = true; indexNull = i + 3 * k; }

                        }

                        if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                    }

                }

               if (flag)

                {

                    for (int k = 0; k < 3; k++)

                    {

                        zero = false; temp = 0;

                        for (int i = 0; i < 3; i++)

                        {

                            if (field[i * 3 + k] == markPC) temp++;

                            if (field[i * 3 + k] == 0) { zero = true; indexNull = i * 3 + k; }

                        }

                        if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                    }
             
                }

                if (flag)

                {

                    zero = false; temp = 0;

                    for (int i = 0; i < 3; i++)

                    {

                        if (field[i * 4] == markPC) temp++;

                        if (field[i * 4] == 0) { zero = true; indexNull = i * 4; }

                    }

                    if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                }

                if (flag)

                {

                    zero = false; temp = 0;

                    for (int i = 0; i < 3; i++)

                    {

                        if (field[(i + 1) * 2] == markPC) temp++;

                        if (field[(i + 1) * 2] == 0) { zero = true; indexNull = (i + 1) * 2; }

                    }

                    if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                }

                ///////////////////////////////////////////////Два знака пользователя в ряду

                if (flag)

                {

                    for (int k = 0; k < 3; k++)

                    {

                        zero = false; temp = 0;

                        for (int i = 0; i < 3; i++)

                        {

                            if (field[i + 3 * k] == mark) temp++;

                            if (field[i + 3 * k] == 0) { zero = true; indexNull = i + 3 * k; }

                        }

                        if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                    }

                }

                if (flag)

                {

                    for (int k = 0; k < 3; k++)

                    {

                        zero = false; temp = 0;

                        for (int i = 0; i < 3; i++)

                        {

                            if (field[i * 3 + k] == mark) temp++;

                            if (field[i * 3 + k] == 0) { zero = true; indexNull = i * 3 + k; }

                        }

                        if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                    }

                }

                if (flag)

                {

                    zero = false; temp = 0;

                    for (int i = 0; i < 3; i++)

                    {

                        if (field[i * 4] == mark) temp++;

                        if (field[i * 4] == 0) { zero = true; indexNull = i * 4; }

                    }

                    if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                }

                if (flag)

                {

                    zero = false; temp = 0;

                    for (int i = 0; i < 3; i++)

                    {

                        if (field[(i + 1) * 2] == mark) temp++;

                        if (field[(i + 1) * 2] == 0) { zero = true; indexNull = (i + 1) * 2; }

                    }

                    if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                }

                //////////////////////////////////////////////Один знак компьютера в ряду и две пустые клетки

                if (flag)

                {

                    for (int k = 0; k < 3; k++)

                    {

                        zero = false; temp = 0;

                        for (int i = 0; i < 3; i++)

                        {

                            if (field[i + 3 * k] == 0) { temp++; indexNull = i + 3 * k; }

                            if (field[i + 3 * k] == markPC) zero = true;

                        }

                        if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                    }

                }

                if (flag)

                {

                    for (int k = 0; k < 3; k++)

                    {

                        zero = false; temp = 0;

                        for (int i = 0; i < 3; i++)

                        {

                            if (field[i * 3 + k] == 0) { temp++; indexNull = i * 3 + k; }

                            if (field[i * 3 + k] == markPC) zero = true;

                        }

                        if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                    }

                }

                if (flag)

                {

                    zero = false; temp = 0;

                    for (int i = 0; i < 3; i++)

                    {

                        if (field[i * 4] == 0) { temp++; indexNull = i * 4; }

                        if (field[i * 4] == markPC) zero = true;

                    }

                    if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                }

                if (flag)

                {

                    zero = false; temp = 0;

                    for (int i = 0; i < 3; i++)

                    {

                        if (field[(i + 1) * 2] == 0) { temp++; indexNull = (i + 1) * 2; }

                        if (field[(i + 1) * 2] == markPC) zero = true;

                    }

                    if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                }

                //////////////////////////////////////////////////Один знак пользователя и две пустые клетки

                if (flag)

                {

                    for (int k = 0; k < 3; k++)

                    {

                        zero = false; temp = 0;

                        for (int i = 0; i < 3; i++)

                        {

                            if (field[i + 3 * k] == 0) { temp++; indexNull = i + 3 * k; }

                            if (field[i + 3 * k] == mark) zero = true;

                        }

                        if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                    }

                }

                if (flag)

                {

                    for (int k = 0; k < 3; k++)

                    {

                        zero = false; temp = 0;

                        for (int i = 0; i < 3; i++)

                        {

                            if (field[i * 3 + k] == 0) { temp++; indexNull = i * 3 + k; }

                            if (field[i * 3 + k] == mark) zero = true;

                        }

                        if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                    }

                }

                if (flag)

                {

                    zero = false; temp = 0;

                    for (int i = 0; i < 3; i++)

                    {

                        if (field[i * 4] == 0) { temp++; indexNull = i * 4; }

                        if (field[i * 4] == mark) zero = true;

                    }

                    if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                }

                if (flag)

                {

                    zero = false; temp = 0;

                    for (int i = 0; i < 3; i++)

                    {

                        if (field[(i + 1) * 2] == 0) { temp++; indexNull = (i + 1) * 2; }

                        if (field[(i + 1) * 2] == mark) zero = true;

                    }

                    if (temp == 2 && zero && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                }

                /////////////////////////////////////////////////////////////////////////Пустые 3 клетки

                if (flag)

                {

                    for (int k = 0; k < 3; k++)

                    {

                        zero = false; temp = 0;

                        for (int i = 0; i < 3; i++)

                        {

                            if (field[i + 3 * k] == 0) { temp++; indexNull = i + 3 * k; }

                        }

                        if (temp == 3 && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                    }

                }

                if (flag)

                {

                    for (int k = 0; k < 3; k++)

                    {

                        zero = false; temp = 0;

                        for (int i = 0; i < 3; i++)

                        {

                            if (field[i * 3 + k] == 0) { temp++; indexNull = i * 3 + k; }

                        }

                        if (temp == 3 && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                    }

                }

                if (flag)

                {

                    zero = false; temp = 0;

                    for (int i = 0; i < 3; i++)

                    {

                        if (field[i * 4] == 0) { temp++; indexNull = i * 4; }

                    }

                    if (temp == 3 && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                }

                if (flag)

                {

                    zero = false; temp = 0;

                    for (int i = 0; i < 3; i++)

                    {

                        if (field[(i + 1) * 2] == 0) { temp++; indexNull = (i + 1) * 2; }

                    }

                    if (temp == 3 && flag) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                }

                ////////////////////////////////////////////////////////В ряду есть знак компьютера и пользователя

                if (flag)

                {

                    for (int k = 0; k < 3; k++)

                    {

                        zero = false; markNull = false; mark_X = false;

                        for (int i = 0; i < 3; i++)

                        {

                            if (field[i + 3 * k] == markPC) markNull = true;

                            if (field[i + 3 * k] == mark) mark_X = true;

                            if (field[i + 3 * k] == 0) { zero = true; indexNull = i + 3 * k; }

                        }

                        if (zero && flag && mark_X && markNull) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                    }

                }

                if (flag)

                {

                    for (int k = 0; k < 3; k++)

                    {

                        zero = false; markNull = false; mark_X = false;

                        for (int i = 0; i < 3; i++)

                        {

                            if (field[i * 3 + k] == 0) { zero = true; indexNull = i * 3 + k; }

                            if (field[i * 3 + k] == mark) mark_X = true;

                            if (field[i * 3 + k] == markPC) markNull = true;

                        }

                        if (zero && flag && mark_X && markNull) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                    }

                }

                if (flag)

                {

                    zero = false; markNull = false; mark_X = false;

                    for (int i = 0; i < 3; i++)

                    {

                        if (field[i * 4] == 0) { zero = true; indexNull = i * 4; }

                        if (field[i * 4] == mark) mark_X = true;

                        if (field[i * 4] == markPC) markNull = true;

                    }

                    if (zero && flag && mark_X && markNull) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                }

                if (flag)

                {

                    zero = false; markNull = false; mark_X = false;

                    for (int i = 0; i < 3; i++)

                    {

                        if (field[(i + 1) * 2] == 0) { zero = true; indexNull = (i + 1) * 2; }

                        if (field[(i + 1) * 2] == mark) mark_X = true;

                        if (field[(i + 1) * 2] == markPC) markNull = true;

                    }

                    if (zero && flag && mark_X && markNull) { index = indexNull; field[index] = markPC; UpdateField(); flag = false; }

                }

            }

            verification();

            bool draw = true;

            for (int i = 0; i < 9; i++) if (field[i] == 0) draw = false;

            if (draw)

            {

                MessageBox.Show(" Draw "); Enable = false;

                Enabledfield();

            }

        }

      

        //Метод проверки выигрыша:

        void verification()

        {

            if (field[0] == mark && field[1] == mark && field[2] == mark && Enable) mark_victory();

            if (field[3] == mark && field[4] == mark && field[5] == mark && Enable) mark_victory();

            if (field[6] == mark && field[7] == mark && field[8] == mark && Enable) mark_victory();

            if (field[0] == mark && field[3] == mark && field[6] == mark && Enable) mark_victory();

            if (field[1] == mark && field[4] == mark && field[7] == mark && Enable) mark_victory();

            if (field[2] == mark && field[5] == mark && field[8] == mark && Enable) mark_victory();

            if (field[0] == mark && field[4] == mark && field[8] == mark && Enable) mark_victory();

            if (field[2] == mark && field[4] == mark && field[6] == mark && Enable) mark_victory();

            if (field[0] == markPC && field[1] == markPC && field[2] == markPC && Enable) markPC_victory();

            if (field[3] == markPC && field[4] == markPC && field[5] == markPC && Enable) markPC_victory();

            if (field[6] == markPC && field[7] == markPC && field[8] == markPC && Enable) markPC_victory();

            if (field[0] == markPC && field[3] == markPC && field[6] == markPC && Enable) markPC_victory();

            if (field[1] == markPC && field[4] == markPC && field[7] == markPC && Enable) markPC_victory();

            if (field[2] == markPC && field[5] == markPC && field[8] == markPC && Enable) markPC_victory();

            if (field[0] == markPC && field[4] == markPC && field[8] == markPC && Enable) markPC_victory();

            if (field[2] == markPC && field[4] == markPC && field[6] == markPC && Enable) markPC_victory();

        }

        //Методы вывода сообщения о победителе:
        
        void mark_victory()
        {
            MessageBox.Show("Winner winner chicken dinner"); Vuser++; Enable = false;

            Enabledfield();
        }

        void markPC_victory()
        {
            MessageBox.Show("Better luck next time");  Vpc++; Enable = false;

            Enabledfield();
        }
    }  
}


