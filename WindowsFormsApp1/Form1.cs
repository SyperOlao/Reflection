using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ClassLibrary2;

    /*
     * Взять за основу задачу 5. Должно быть не менее 3 классов,
     * которые наследуются от абстрактного класса. Используя рефлексию
     * реализовать возможность создания и вызова методов данных классов на форме.
     * Написать код, который принимает путь к библиотеке классов и ищет все классы,
     * которые реализуют интерфейс. Далее получают всю информацию о данных классах,
     * и возвращают список из названий классов. На форме реализовать «дроплаун» с названиями классов.
     * При выборе класса на форму должны динамически подгружаться все методы класса с возможностью
     * ввода параметров пользователем.
     * При нажатии кнопки «Выполнить» должен создаваться объект и выполняться выбранный метод.
     */

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var asm = Assembly.Load("ClassLibrary2");
            var types = asm.GetTypes();
            var result = types.Where(x => x.GetInterface("IFurniture") != null);
            label1.Text = "1";
            foreach (var r in result)
            {
                comboBox1.Items.Add(r);
            }

            label1.Text += comboBox1.SelectedText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox1.SelectedItem;
            label1.Text = item.ToString();
            var type = typeof(IFurniture);
            foreach (var method in type.GetMethods())
            {
                comboBox2.Items.Add(method.Name);
            }
        }
        
        public static void ShowMethods(Type type)
        {
            foreach (var method in type.GetMethods())
            {
                var parameters = method.GetParameters();
                var parameterDescriptions = string.Join
                (", ", method.GetParameters()
                    .Select(x => x.ParameterType + " " + x.Name)
                    .ToArray());

                Console.WriteLine("{0} {1} ({2})",
                    method.ReturnType,
                    method.Name,
                    parameterDescriptions);
            }
        }
    }
}