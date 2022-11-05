# Цацко нема компири 
## В.П. проект 

Со овој Windows Forms проект е изработен тип на игра каде целта на играчот е да собере што повеќе паѓачки предмети движејќи се лево и десно по дното на прозорецот.
За изработка се искористини 2 форми.

Инспирација за конкретно оваа од тој тип на игри е скеч од К-15 насловен "Цацко нема компири" : <br>
https://www.youtube.com/watch?v=OnZWBggRHw0
<br>

### How to play?
Играчот(со ликот на Цацко) може да се движи лево и десно со помош на стрелките од тастатура или копчињата <kbd>А</kbd> и <kbd>D</kbd>. <br>
Целта на Цацко е да собере што повеќе компири за пире без притоа да промаши повеќе од 5 пати. <br>
demo: https://youtu.be/KWaFtcJf4lA

### Start Menu:
При укуличување на играта првиот прозорец со кој се среќава играчот е следниот: <br>

![Screenshot_6](https://user-images.githubusercontent.com/80720596/200021914-cefe148c-7286-4fb6-a3b0-c45dc61725c6.png)<br>

Истиот при појавување е придружен со реченица на Цацко од видеото и со позната К-15 песна едитирана со цел да е соодветна инструментална позадинска музика на играта. Ова е овозможено со помош на класите `SoundPlayer` и `AxWMPLib.AxWindowsMediaPlayer` (Windows Media Player алатката од Toolbox) кои овозможуваат .wav фајловите да се пуштат паралелно со приклучување на апликацијата. <br>
Изреката на Цацко се пушта само еднаш на почеток, а позадинската музика е наместена да се врти во циклус. <br>

Со притискање на копчето Start тековниот прозорец `StartMenu` го снемува и се појавува нов прозорец `Game` каде играта започнува. <br>
```c#        
        private void pbStart_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            MP.Ctlcontrols.stop(); // pozadinskata muzika zapira (i se pusta pak vo noviot prozorec)
            this.Hide();
            game.Show();
        }
```        

### The Game:
![Screenshot_2](https://user-images.githubusercontent.com/80720596/198855322-3ecf6745-ede4-4689-b936-d6711f460a7f.png) <br>

На екранот покрај 5те животи(срциња) кои се во десниот горен агол има и опција mute/unmute, највисок постигнат резултат и тековниот резултат на играчот кои се наоѓаат во левиот горен агол.

На секој секој 10 собрани компири (секој следен кат) се забрзува брзината на паѓање на компирите.

На секој промашен компир се менува изразот на Цацко и паднатиот компир станува смачкан. <br>

![Screenshot_4](https://user-images.githubusercontent.com/80720596/198855492-386b08a6-d2d4-4a2b-a149-5befcfeb82a8.png) <br>

На копчето од тастатура Escape играта се паузира и на екран во истиот прозорец се појавуваат 3 опции:
 * Continue - да се продолжи играта понатаму
 * Restart - играта да почне одново
 * Quit - да се изгаси апликацијата
Ова е овозможено со:
```c#
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Escape)
            {
                timer.Stop();
                pausedMenu.Show();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
```

![Screenshot_7](https://user-images.githubusercontent.com/80720596/200137083-7ee4824d-081a-4904-bc26-1608f46b5f75.png) <br>

#### Player Movement:
Движењето е овозможено на следниот начин:

```c#
        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                right = false;
            }

        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) // pritisnato e kopce za levo
            {
                left = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) // pritisnato e kopce za desno
            {
                right = true;
            }
        }
```

Исто така движењето на Цацко е ограничено со услови во `timer_Tick()` функцијата:

```c#
            if (left == true && Cacko.Left > 0) // ako e pritisnato kopce za levo i levata strana na Cacko e > 0
            {
                Cacko.Left -= 15; // dvizi na levo 15 pixels
                Cacko.Image = Properties.Resources.left; // ja menuva slikata za levo
                dir = 0; // levo
            }

            if (right == true && Cacko.Left + Cacko.Width < this.ClientSize.Width) // ako e pritisnato kopce za desno i Cacko ne izlaga desno od ekran
            {
                Cacko.Left += 15; // go pomestuva igracot 15 pixels desno
                Cacko.Image = Properties.Resources.right; // menuva slika za desno
                dir = 1; // desno
            }
```

Овде bool променливата `dir` ни служи како маркер за промена на сликата кога на Цацко ќе му паден компир. Уптребена е на следен начин:

```c#
                        if(dir == 0)
                        {
                            Cacko.Image = Properties.Resources.leftERROR;
                        } 
                        else if (dir == 1)
                        {
                            Cacko.Image = Properties.Resources.rightERROR;
                        }
```

#### 5 Hearts:
Играчот има 5 животи или 5 можности да промаши компир. При градење во формата се ставени 5 полни срциња и со секое промашување се менува сликата на секое следно срце едно по едно почнувајќи од лево кон десно во црно-бело:
```c#
        void hearts()
        {
            if (missed == 1)
            {
                life1.Image = Properties.Resources.GREYheart;
            }
            if (missed == 2)
            {
                life2.Image = Properties.Resources.GREYheart;
            }
            if (missed == 3)
            {
                life3.Image = Properties.Resources.GREYheart;
            }
            if (missed == 4)
            {
                life4.Image = Properties.Resources.GREYheart;
            }
            if (missed == 5)
            {
                life5.Image = Properties.Resources.GREYheart;
                timer.Stop();
                Menu.Show(); // Menu e GroupBox

                fin = new SoundPlayer(@"FIN.wav");
                fin.Play();
            }
        }
```
Кога играчот ќе ги изгуби сите животи се пушта уште една реченица на Цацко од видеото и се појавуваат 2 опции на екранот: <br>
* Restart - за одново иницијализирање на истиот прозорец
* Quit - за терминирање на апликацијата

![Screenshot_5](https://user-images.githubusercontent.com/80720596/198886746-0e952cf6-4c46-4a21-a345-9cd66aa82580.png) <br>

#### High Score:
Најголемиот постигнат резултат е прикажан на двата прозорци кои се појавуваат. Доколку играчот постигне поголем резултат од моменталниот максимален се поставува новодобиениот резултат за High Score. Ова е реализирано со додавање на вредност во Properties -> Settings табот со default вредности која може да се пристапи и промени со `Properties.Settings.Default.highScore`. Оваа вредност се памти и се вчитува со секое вклучување на апликацијата.

### Score:
Оваа вредност се поставува на 0 со секое вклучување на играта и го означува тековниот резултат на играчот.

#### Mute/Unmute:
И во оваа форма ја има Windows Music PLayer алатката кој е придружен со 2 слики кои се наоѓаат на иста локација и наизменично се менуваат при клик (во едно време само една е видлива). Секоја од нив означува една од 2 состојби:
1. Сликата е зелена, музиката се слуша -> при клик на зеленото копче музиката се паузира и копчето станува црвено.
2. Сликата е црвна, музиката е паузирана -> при клик музиката продолжува и копчето станува зелено.

Реализирано на следниот начин:

```c#
        private void pbPlay_Click(object sender, EventArgs e)
        {
            MPForm.Ctlcontrols.pause();     
            pbMute.Visible = true;
            pbPlay.Visible = false;
        }

        private void pbMute_Click(object sender, EventArgs e)
        {
            MPForm.Ctlcontrols.play();
            pbMute.Visible = false;
            pbPlay.Visible = true;
        }
```

#### Floors:
Бидејќи во скечот Цацко се качува 10 катови за да побара компири од Тошо решив левелите во играта да се репрезентирани со римски броеви на катови.
```c#
        const string R_one = "I";
        const string R_two = "II";
        const string R_three = "III";
        const string R_four = "IV";
        const string R_five = "V";
        const string R_six = "VI";
        const string R_seven = "VII";
        const string R_eight = "VIII";
        const string R_nine = "IX";
        const string R_ten = "X"; // na ovoj kat e Tosho xD
```

Бидејќи секој левел/кат брзината на паѓање на компирите се зголемува, а левелот се зголемува со секој 10ти собран компир менувањето број на кат е имплементирано на следниот начин:

```c#
if (counterSpeed == 10) // na sekoj 10ti kompir da se zgolemi brzinata
            {
                speed += 3; // zgolemuva brzina na paganje na kompirite
                counterSpeed = 0;
                floor += 1;

                switch (floor)
                {
                    case 1:
                        lblFloorNumber.Text = R_one;
                        break;
                    case 2:
                        lblFloorNumber.Text = R_two;
                        break;
                    case 3:
                        lblFloorNumber.Text = R_three;
                        break;
                    case 4:
                        lblFloorNumber.Text = R_four;
                        break;
                    case 5:
                        lblFloorNumber.Text = R_five;
                        break;
                    case 6:
                        lblFloorNumber.Text = R_six;
                        break;
                    case 7:
                        lblFloorNumber.Text = R_seven;
                        break;
                    case 8:
                        lblFloorNumber.Text = R_eight;
                        break;
                    case 9:
                        lblFloorNumber.Text = R_nine;
                        break;
                    case 10:
                        lblFloorNumber.Text = R_ten;
                        break;
                    default:
                        lblFloorNumber.Text = "xD";
                        break;
                } 
            }
```

#### The Potatoes:
Компирите (вкупно 2) се spawn-нуваат надвор од горниот раб на прозорецот (позициите имаат негативни врености за `y`). Првиот `k1` има вредности за `x` кои се движат од онолку колку што е широк еден компир до половина од прозорецот, а за вториот `k2`вредностите се движат од половината на прозорецот до колку што е широк истиот прозорец минус широчинта на еден компир. <br>
Ова е овозножено со: <br>
```c#
                    if (c.Name == "k1")
                    {
                        c.Top = randomY.Next(50, 51) * -1;
                        c.Left = randomX.Next(c.Width, this.ClientSize.Width / 2);
                    }
                    else if (c.Name == "k2")
                    {
                        c.Top = randomY.Next(500, 501) * -1;
                        c.Left = randomX.Next(this.ClientSize.Width / 2, this.ClientSize.Width - c.Width);
                    }
```
 Со тоа што има мало поместување на `y` вредноста зависно дали цацко ќе го фати компирот или не со цел секој пат да изминуваат исто растојание при паѓање.


