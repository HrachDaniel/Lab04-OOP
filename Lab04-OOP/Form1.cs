using System;
using System.Text;
using System.Windows.Forms;

namespace Lab04_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // --- ЗАВДАННЯ 1: Одновимірний масив ---
        // Кнопка: btnCalcTask1
        private void btnCalcTask1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Зчитування масиву з текстового поля
                // Split розбиває рядок за пробілами, RemoveEmptyEntries видаляє зайві пробіли (якщо користувач ввів кілька підряд)
                string[] stringParts = txtArrayInput.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Якщо нічого не введено — виходимо
                if (stringParts.Length == 0) return;

                // Створення масиву чисел
                double[] arr = new double[stringParts.Length];
                for (int i = 0; i < stringParts.Length; i++)
                {
                    // Парсинг рядка в число. Якщо введено літеру замість цифри — показуємо помилку.
                    if (!double.TryParse(stringParts[i], out arr[i]))
                    {
                        MessageBox.Show($"Некоректне значення: {stringParts[i]}");
                        return;
                    }
                }

                // Зберігаємо початковий вигляд масиву в рядок для відображення в звіті
                string originalArrayStr = string.Join(";  ", arr);

                // --- а) Підрахунок кількості від’ємних елементів ---
                int negativeCount = 0;
                foreach (var item in arr)
                {
                    if (item < 0) negativeCount++;
                }

                // --- б) Пошук мінімального елемента за модулем ---
                int minAbsIndex = 0;
                double minAbsValue = Math.Abs(arr[0]); // Припускаємо, що перший елемент — шуканий

                for (int i = 1; i < arr.Length; i++)
                {
                    double currentAbs = Math.Abs(arr[i]);

                    // Логіка оновлення мінімуму:
                    // 1. Якщо поточний модуль менший за знайдений мінімум.
                    // 2. АБО якщо модулі рівні (наприклад |1| == |-1|), але саме число менше 
                    // (це важливо, щоб між 1 та -1 програма обрала -1 як "менше" алгебраїчно).
                    if (currentAbs < minAbsValue || (currentAbs == minAbsValue && arr[i] < arr[minAbsIndex]))
                    {
                        minAbsValue = currentAbs;
                        minAbsIndex = i; // Запам'ятовуємо новий індекс
                    }
                }

                // Зберігаємо реальне значення знайденого елемента (поки масив ще не змінено)
                double actualMinElement = arr[minAbsIndex];

                // Рахуємо суму модулів елементів, що стоять ПІСЛЯ знайденого індексу
                double sumAfterMin = 0;
                for (int i = minAbsIndex + 1; i < arr.Length; i++)
                {
                    sumAfterMin += Math.Abs(arr[i]);
                }

                // Формуємо текст зі статистикою
                string statsOutput = $"К-сть від'ємних: {negativeCount}\n" +
                                     $"Індекс мін. за модулем: {minAbsIndex} (значення {actualMinElement})\n" +
                                     $"Сума модулів після мін.: {sumAfterMin:F2}";

                // --- Модифікація та Сортування ---
                // 1. Заміна всіх від'ємних чисел на їх квадрати (наприклад, -4 стає 16, -1 стає 1)
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0) arr[i] = arr[i] * arr[i];
                }

                // 2. Сортування масиву за зростанням (сортується вже змінений масив без від'ємних чисел)
                Array.Sort(arr);

                // --- Вивід результатів ---
                lblStats.Text = statsOutput;
                // Виводимо початковий масив та масив після обробки
                txtArrayResult.Text = "=== Початковий масив ===\r\n" + originalArrayStr + "\r\n\r\n" +
                                      "=== Оброблений масив (заміна + сортування) ===\r\n" +
                                      string.Join(";  ", arr);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        // --- ЗАВДАННЯ 2: Двовимірний масив (Матриця) ---
        // Кнопка: btnCalcTask2
        private void btnCalcTask2_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримуємо розміри матриці з полів введення (NumericUpDown)
                int rows = (int)numRows.Value;
                int cols = (int)numCols.Value;

                // Зчитуємо номер рядка m, який ввів користувач (наприклад, 1-й, 2-й...)
                int mUser = (int)numM.Value;

                // Перетворюємо людський номер (починається з 1) у програмний індекс (починається з 0)
                // Наприклад: користувач ввів 1 -> програмі потрібен індекс 0
                int mIndex = mUser - 1;

                // Перевірка: чи входить введений рядок у межі масиву (від 0 до rows-1)
                if (mIndex < 0 || mIndex >= rows)
                {
                    MessageBox.Show($"Для масиву з {rows} рядків введіть номер m від 1 до {rows}.");
                    return;
                }

                // Перевірка: чи достатньо стовпців для виконання умови (вивід 2-го стовпця)
                if (cols < 2)
                {
                    MessageBox.Show("Масив повинен мати мінімум 2 стовпці.");
                    return;
                }

                // --- Генерація матриці ---
                int[,] matrix = new int[rows, cols];
                Random rnd = new Random();
                StringBuilder sbMatrix = new StringBuilder(); // Використовуємо StringBuilder для швидкого формування тексту

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        // Генеруємо випадкове число від -10 до 50
                        matrix[i, j] = rnd.Next(-10, 50);
                        // Додаємо число до рядка, PadLeft(5) додає пробіли зліва для вирівнювання стовпчиків
                        sbMatrix.Append(matrix[i, j].ToString().PadLeft(5));
                    }
                    sbMatrix.AppendLine(); // Перехід на новий рядок після заповнення поточного рядка матриці
                }

                // а) Вивід усієї згенерованої матриці у велике текстове поле
                txtMatrixOutput.Text = sbMatrix.ToString();

                // б) Формування та вивід 2-го стовпця (індекс 1, бо нумерація з 0)
                StringBuilder sbCol2 = new StringBuilder();
                for (int i = 0; i < rows; i++)
                {
                    sbCol2.Append(matrix[i, 1] + "; ");
                }
                lblCol2.Text = $"2-й стовпець: {sbCol2}";

                // в) Формування та вивід m-го рядка
                // Використовуємо обчислений раніше mIndex (правильний індекс масиву)
                StringBuilder sbRowM = new StringBuilder();
                for (int j = 0; j < cols; j++)
                {
                    sbRowM.Append(matrix[mIndex, j] + "; ");
                }

                // У підписі (Label) показуємо число mUser (те, що ввів користувач), щоб не плутати його
                lblRowM.Text = $"{mUser}-й рядок: {sbRowM}";

            }
            catch (Exception ex)
            {
                // Загальна обробка непередбачених помилок
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
}