TheHive
=======

Објаснување на проблемот
=======

Бидејќи во денешно време голем број од луѓето се корисници на персонални компјутери, лаптопи и паметни телефони, сите тие наоѓаат занимација во игрите. Затоа ние одлучивме тема на нашата семинарска да биде развивање на игра. Нашата игра се вика The Hive.

Идејата ја добивме од играта Sporos, логичка игра која за многу брзо време стана популарна помеѓу корисниците на Android и iOS паметни телефони и таблети. Станува збор за логичка игра која што се состои од повеќе нивоа. Секое ниво се состои од матрица од ќелии, која што треба целосно да се пополни за да се помине нивото. Ќелиите се пополнуваат со одредени објекти кои што ни се понудени со можност да пополнуваат ќелии во 2, 4 или 6 насоки.  Во оригиналната игра матрицата со ќелии всушност претстатува матрица од неутрални клетки, а објектите со кои пополнуваме се вирусни клетки. За да се помине нивото потребно е да се инфицираат сите клетки. Во нашата игра, The Hive, матрицата од ќелии претставуваат саќиња, а објектите за пополнување се пчели. За да се помине нивото потребно е да се наполнат сите саќиња со мед.

Откако ќе ја пуштиме играта на почеток се појавува мени каде што е прикажано логото на играта и копче PLAY, со кое преминуваме на нивоата на играта.



Кога ќе ни се прикажат нивоата можеме да одбереме кое ниво ќе го играме, со тоа што отворени за играње се поминатите нивоа, како и следното ниво што треба да се одигра. Со секое поминато ниво се отклучува следното.

Во прозорецот каде што е самата игра прикажани се матрицата со саќиња и пчелите кои се на располагање за соодветното ниво. Дополнително има две копчиња, LEVELS со кое се враќаме на прозорецот со нивоата, и копчето RESTART кое што го рестартира нивото така што ги враќа сите пчели на почетната состојба. Исто така, во долниот десен агол има тајмер од 30 секунди. Кога ќе истече времето добиваме на располагање еден "hint". При започнување на ново ниво тајмерот се ресетира, почнува да одбројува нови 30 секунди.

Упатство за играње
=======

За да можеме да ја играме играта, потребно е претходно да се запознаеме со видовите на пчели и полиња.

Пчелите се движат во 2, 4 или 6 насоки.	 	 	 	 	 

Полињата можат да бидат празни, полни со мед или потенцијално полни (hover):

При започнување на ново ниво сите ќелии се празни. Целта е да се пополнат сите ќелии.
Играта се игра само со клик на глувчето. Со лев клик се зема пчела од нејзиното поле. Истото се постигнува доколку кликнеме на ќелија која содржи пчела, со тоа што ќе се испразнат полињата кои што таа ги имала пополнето. Доколку веќе имаме земено пчела, со лев клик истата ја оставаме во некоја од ќелиите и притоа ќе се пополнат соодветните полиња. Пчелата може да се остави само на празна ќелија. Полињата ќе се пополнуваат во една насока сѐ додека не стигне до друга пчела или дупка во матрицата.
Со десен клик на пчела која е поставена во ќелија, таа се враќа на почетната позиција. Исто така, доколку имаме земено пчела со лев клик, истата може да ја вратиме со десен клик.
Доколку не можеме да го поминеме нивото, тогаш може да го кликнеме копчето за "hint", при што нивото се ресетира и првата пчела се поставува на точната ќелија во матрицата.

Решение на проблемот
=======

  За константите и податоците за нивоата напишавме класа Constants. Таа содржи:
-	Сите видови на пчели и состојби на ќелии – int
-	Низа од парови  на координати за секој вид на пчела – со листање на овие парови прикажуваме насока на движење на секоја пчела – int[][]
-	Листа од матрици за сите нивоа – се добива со конверзија на string – List<int[][]>
-	Листа од пчели за сите нивоа – секое ниво содржи посебна листа од видови на пчели – List<List<int>>
-	Листа од "hint"-ови – секое ниво содржи листа од Point кој ги означува координатите на кои што треба да биде поставена пчелата – List<List<Point>>

Податоците за секоја пчела се чуваат во класата Bee. Таа содржи:
-	Локацијата каде се наоѓа пчелата на почеток на нивото – Point
-	Координати каде се наоѓа пчелата откако ќе се остави во матрицата – Point
-	Променлива за дали пчелата е видлива – bool
-	Променлива за дали пчелата е оставена во матрицата – bool
-	Променлива за видот на пчелата – int
-	Променлива која чува во кој чекор е оставена пчелата – int
-	Индексот на пчелата – int

Податоците за секоја ќелија се чуваат во класата Slot. Таа содржи:
-	Локацијата на ќелијата – Point
-	Променлива која ја чува состојбата на ќелијата – int
-	Променлива која покажува дали со спуштање на пчела во било која ќелија, би се пополнила моменталната – bool
-	Променлива која го чува индексот на пчелата која се наоѓа во таа ќелија. Доколку нема пчела вредноста е -1 – int
-	Координатите на ќелијата – int, int

Преку Select Level формата се започнува нова игра (нова форма Game). Со променлива од Settings документот (int) обележуваме до кое ниво стигнал корисникот. Оваа променлива ќе биде зачувана и во случај да се изгаси апликацијата и одново да се пушти.

Во формата Game се одвива целата игра. Таа содржи:
-	Матрица од Slot која ја претставува матрицата од ќелиите – Slot[][]
-	Листа од Bee која ги претставува пчелите на моменталното ниво – List<Bee>
-	Променлива која го чува моменталното ниво – int
-	Објект од класата на константи – Constants
-	Индекс на селектираната пчела. Доколку нема селектирана индексот е -1 – int
-	Променлива која брои колку полиња вкупно има матрицата – int
-	Променлива која брои колку полиња се моментално пополнети – int
-	Дополнителни променливи за состојбата на “Hint” – дали е достапен или не, број на секунди до можноста за користење на “hint” и објект од класата Timer

Опис на функции
=====

Функцијата void BeeEvent(Bee bee) служи за поставување на пчела во одредена ќелија. Пред повикот на функцијата во bee објекот се зачувуваат координатите на кои треба да се постави пчелата. 

public void BeeEvent(Bee bee)
{
    // Иницијализација на кооординатите
    int i = bee.DropCoordinates.X;
    int j = bee.DropCoordinates.Y;

    // Промена на состојбата на ќелијата, се зачувува видот на пчелата. Промена на индексот на пчелата
    Slots[i][j].State = bee.BeeType;
    Slots[i][j].BeeIndex = bee.i;
    int currentBee = bee.BeeType;

    // Ги земаме листите со координати кои ги означуваат насоките на движење на пчелите.
    int[][] array = getArray(currentBee);

    foreach (int[] pair in array)
    {
        // Со секој пар се добиваат различни координати за движење низ матрицата.
        int X = i + pair[0];
        int Y = j + pair[1];

        // Се додека не се излезе од матрицата или не дојдеме до дупка во матрицата или ќелија со пчела, 
        // пополнувањето во одредена насока продолжува
        while (X >= 0 && X < Slots.Length && Y >= 0 && Y < Slots[0].Length && Slots[X][Y] != null && Slots[X][Y].State < 2)
        {
            if (Slots[X][Y].State == Constants.Free)
            {
                FilledSlots++;
            }
            Slots[X][Y].State = Constants.Filled;



            X += pair[0];
            Y += pair[1];
        }
    }

    // Зголемување на бројот на пополнети ќелии и извршување на функцијата WinLevel
    FilledSlots++;
    WinLevel();
}

Функцијата void WinLevel() се користи за проверка дали е поминато нивото и доколку е се извршуваат соодветните функции.

private void WinLevel()
{
    // Проверка дали сите ќелии се пополнети
    if (FilledSlots == SlotCount)
    {
        // Се ресетира тајмерот на почетната состојба
        HintUsed = true;
        lblHint.Text = "Hint in 0:30";
        lblHint.ForeColor = Color.FromArgb(255, 150, 0);
        HintTimeLeft = 30;
        HintTimer.Start();

        // Проверка дали било поминато последното ниво
        if (level + 1 == Constants.LevelMatrices.Count)
        {
            // Нема веќе нивоа за играње. Формата се затвора
            won = true;
            DialogResult dr = MessageBox.Show("Congratulations, you passed all levels!");
            DialogResult = DialogResult.No;
            Close();
        }
        else
        {
            // Поминато е моменталното ниво, го иницијализираме следното.

            // Се покажува текст дека сме го поминале нивото
            lblLevelPassed.Text = "Level " + (level + 1) + " passed!";
            lblLevelPassed.Visible = true;

            // Иницијализација на новото ниво
            won = false;
            InitializeLevel(++level);
            Invalidate(true);

            // По 2.5 секунди текстот за поминато ниво се крие
            Timer timer = new Timer();
            timer.Interval = 2500;
            timer.Tick += (arg1, arg2) =>
            {
                lblLevelPassed.Visible = false;
                timer.Stop();
                timer.Dispose();
            };

            timer.Start();
        }
    }
}

Функцијата void DropBee(int i, int j) користи за поставување на селектирана пчела во некоја од ќелиите.

public void DropBee(int i, int j)
{
    // Курсорот се поставува на default курсор.
    Cursor = Cursors.Default;

    // Селектираната пчела ја означуваме дека е поставена во ќелија.
    // Зачувуваме во кој чекор е поставена пчелата
    // Ги зачувуваме координатите на ќелијата.
    Bees[SelectedBeeIndex].Dropped = true;
    Bees[SelectedBeeIndex].DropTimer = DropTimer++;
    Bees[SelectedBeeIndex].DropCoordinates = new Point(i, j);

    // Означуваме дека веќе нема селектирана пчела.
    SelectedBeeIndex = -1;

    // Одново се повикува BeeEvent за секоја пчела која има Dropped = true, во растечки редослед во однос на нивниот DropTimer.
    ExecuteBeeEvents();
}


