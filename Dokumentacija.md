# Цацко нема компири 
## В.П. проект 

Со овој Windows Forms проект е изработен тип на игра каде целта на играчот е да собере што повеќе паѓачки предмети движејќи се лево и десно по дното на прозорецот.
За изработка се искористини 2 форми.

Инспирација за конкретно оваа од тој тип на игри е скеч од К-15 насловен "Цацко нема компири" : <br>
https://www.youtube.com/watch?v=OnZWBggRHw0
<br>
### Start Menu:
При укуличување на играта првиот прозорец со кој се среќава играчот е следниот: <br>

![Screenshot_1](https://user-images.githubusercontent.com/54687796/198845106-28efcae4-ca5e-4d91-a66d-7485853e3e82.png) <br>

Истиот при појавување е придружен со реченица на Цацко од видеото и со позната К-15 песна едитирана со цел да е соодветна инструментална позадинска музика на играта. Ова е овозможено со помош на класите `SoundPlayer` и `AxWMPLib.AxWindowsMediaPlayer` (Windows Media Player алатката од Toolbox) кои овозможуваат .wav фајловите да се пуштат паралелно со приклучување на апликацијата. <br>
Изреката на Цацко се пушта само еднаш на почеток, а позадинската музика е наместена да се врти во циклус. <br>

Со притисканје на копчето Start тековниот прозорец `StartMenu` го снемува и се појавува нов `Game` каде играта започнува. <br>
```c#        
        private void pbStart_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            MP.Ctlcontrols.stop(); // pozadinskata muzika zapira (i se pusta pak vo noviot prozorec)
            this.Hide();
            game.Show();
        }
```        

### The Basics & How to Play:
Играчот(со ликот на Цацко) може да се движи лево и десно со помош на стрелките од тастатура или копчињата А и D (како што е наведено и на почетниот прозорец). Ова е овозможено на следниот начин:

```
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

Целта е Цацко да собере што повеќе компири за пире без да промаши повеќе од 5 пати. <br>

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

### How it's made ?
Најпрвин започнав со изгледот опишан погоре, со функционалноста на елементите и на крај со музиката и звучните ефекти. 

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

### High Score:
Најголемиот постигнат резултат е прикажан на двата прозорци кои се појавуваат. Доколку играчот постигне поголем резултат од моменталниот максимален се поставува новодобиениот резултат за High Score. Ова е реализирано со додавање на вредност во Properties -> Settings табот со default вредности која може да се пристапи и промени со `Properties.Settings.Default.highScore`. Оваа вредност се памти и се вчитува со секое вклучување на апликацијата.

### Score:
Оваа вредност се поставува на 0 со секое вклучување на играта и го означува тековниот резултат на играчот.

### Mute/Unmute:
И во оваа форма ја има Windows Music PLayer алатката кој е придружен со 2 слики кои се наоѓаат на иста локација и наизменично се менуваат при клик (во едно време само една е видлива). Секоја од нив означува една од 2 состојби:
1. Сликата е зелена, музиката се слуша -> при клик на зеленото копче музиката се паузира и копчето станува црвено.
2. Сликата е црвна, музиката е паузирана -> при клик музиката продолжува и копчето станува зелено.

Реализирано на следниот начин:

```
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

### Kompiri:





