using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Kutya
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Reading the KutyaNevek.csv file
            Dictionary<int, string> dogNames = new Dictionary<int, string>();
            StreamReader sr = new StreamReader("KutyaNevek.csv");
            sr.ReadLine();

            while(!sr.EndOfStream)
            {
                string[] datas = sr.ReadLine().Split(";");
                dogNames[int.Parse(datas[0])] = datas[1];
            }
            sr.Close();

            // Reading the KutyaFajtak.csv file
            Dictionary<int, List<string>> dogTypes = new Dictionary<int, List<string>>();
            sr = new StreamReader("KutyaFajtak.csv");
            sr.ReadLine();
            while(!sr.EndOfStream)
            {
                string[] datas = sr.ReadLine().Split(";");
                dogTypes[int.Parse(datas[0])] = new List<string>() { datas[1], datas[2] };
            }
            sr.Close();

            // Reading the Kutyak.csv file
            List<Dog> dogs = new List<Dog>();
            sr = new StreamReader("Kutyak.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] datas = sr.ReadLine().Split(";");
                Dog dog = new Dog(int.Parse(datas[0]), int.Parse(datas[1]), int.Parse(datas[2]), int.Parse(datas[3]), datas[4].Split(";"));
                dogs.Add(dog);
            }

            // 3. feladat:
            MessageBox.Show($"3. feladat: Kutyanevek száma: {dogNames.Count}");

            // 6. feladat
            MessageBox.Show($"6. feladat: Kutyák átlagéletkora: {Math.Round(dogs.Average(x => x.Age), 2)}");

            // 7. feladat
            Dog oldestDog = dogs.MaxBy(x => x.Age);
            string oldestDogName = dogNames[oldestDog.DogNameId];
            string oldestDogType = dogTypes[oldestDog.DogTypeId][0];
            MessageBox.Show($"7. feladat: Legidősebb kutya neve és fajtája: {oldestDogName}, {oldestDogType}");

            // 8. feladat
            
        }

    }
}
