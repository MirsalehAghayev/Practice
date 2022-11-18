using System;
using System.Collections.Generic;
using ConsoleApp1.Helpers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course("CodeAcademy");


            while (true)
            {

                Helper.Print("1.Qrup elave et 2.Qruplari gor 3.Qrupa Student elave et  4.Studentleri gor  5.Student uzre axtaris 6.Qrupdan student sil 7.Qrupdaki studenti editle", ConsoleColor.Green);
                string numm = Console.ReadLine();
                bool isInt = int.TryParse(numm, out int menu);
                switch (menu)
                {
                    case 1:
                     
                        grname:
                        Helper.Print("Yeni yaradacaqiniz qrupun adini qeyd edin:", ConsoleColor.Green);
                        string grname = Console.ReadLine();

                        foreach (var item in course.groups)
                        {
                            if (item.Name == grname)
                            {
                                Helper.Print("Bu adda qrup var,basqa ad daxil edin", ConsoleColor.Red);
                                goto grname;
                            }
                        }
                        Group group = new Group(grname);
                        course.groups.Add(group);
                        Helper.Print($"{grname} adli qrup yaradildi", ConsoleColor.Yellow);
                        break;
                    

                    case 2:
                        
                        if (course.groups.Count == 0)
                        {
                            Helper.Print("Yaradilmis qrup yoxdur, qrup yaradin", ConsoleColor.Red);
                        }
                        foreach (var item in course.groups)
                        {
                            Helper.Print($"{item.Name}", ConsoleColor.Yellow);
                        }
                        break;
                   
                    case 3:
                        
                    case 4:
                        
                        if (course.groups.Count == 0)
                        {
                            Helper.Print("Yaradilmis qrup yoxdur,qrup yaradin", ConsoleColor.Red);
                            goto case 1;
                        }

                        foreach (var item in course.groups)
                        {
                            Helper.Print($"{item.Name}", ConsoleColor.Yellow);
                        }
                        grpName:
                        Helper.Print("Gormek istediyiniz qrupun adini qeyd edin:", ConsoleColor.Green);
                        string grpn = Console.ReadLine();

                        foreach (var item in course.groups)
                        {

                            if (grpn == item.Name)
                            {
                                if (item.studens.Count == 0)
                                {
                                    Helper.Print("Bu qrupda student yoxdur", ConsoleColor.Red);
                                }
                                else
                                {
                                    foreach (var item1 in item.studens)
                                    {
                                        Helper.Print($" Ad-{item1.Name}  Soyad-{item1.Surname} Yas-{item1.Age} Bal-{item1.Grade}", ConsoleColor.Yellow);
                                    }
                                }
                            }
                            
                        }

                        break;
                    
                    case 5:
                       

                        Helper.Print("Axtaris etmek istediyinz telebe adi", ConsoleColor.Green);
                        string stn = Console.ReadLine();

                        foreach (var item in course.groups)
                        {
                            foreach (var item1 in item.studens)
                            {
                                if (stn.ToUpper() == item1.Name.ToUpper())
                                {
                                    Helper.Print($"{item1.Id}  {item1.Name} {item1.Surname}", ConsoleColor.Yellow);
                                }
                                
                            }
                        }

                        break;
                  
                    case 6:
                      
                        if (course.groups.Count == 0)
                        {
                            Helper.Print("Yaradilmis qrup yoxdur,qrup yaradin", ConsoleColor.Red);
                            goto case 1;
                        }
                        foreach (var item in course.groups)
                        {
                            Helper.Print($"{item.Name}", ConsoleColor.Yellow);
                        }
                        Helper.Print("Hansi qrupdan student silmek isteyirsiz?", ConsoleColor.Green);
                        string dlt = Console.ReadLine();
                        foreach (var item in course.groups)
                        {
                            if (dlt == item.Name)
                            {
                                foreach (var item1 in item.studens)
                                {
                                    Helper.Print($"Id:{item1.Id} AD:{item1.Name}", ConsoleColor.Yellow);
                                }
                            }
                        }
                        Id:
                        Helper.Print("Silmek istediyiniz studentin ID qeyd edin", ConsoleColor.Green);

                        string idd = Console.ReadLine();
                        bool isid = int.TryParse(idd, out int id_);
                        if (!isid)
                        {
                            Console.WriteLine("Yanlis daxil edildi,Duzgun daxil edin");
                            goto Id;
                        }
                        foreach (var item in course.groups)
                        {
                            foreach (var item1 in item.studens)
                            {
                                if (item1.Id == id_)
                                {
                                    item.studens.Remove(item1);
                                    Helper.Print($"{item1.Name} adli telebe silindi ", ConsoleColor.Yellow);
                                    break;
                                }
                            }
                        }
                        break;
                    
                    case 7:
                        
                        if (course.groups.Count == 0)
                        {
                            Helper.Print("Yaradilmis qrup yoxdur, qrup yaradin", ConsoleColor.Red);
                            goto case 1;
                        }
                        foreach (var item in course.groups)
                        {
                            Helper.Print($"{item.Name}", ConsoleColor.Yellow);
                        }
                        Helper.Print("Hansi qrupda telebe editlemek isteyirsiniz?", ConsoleColor.Green);
                        string edt = Console.ReadLine();
                        foreach (var item in course.groups)
                        {

                            if (edt == item.Name)
                            {
                                if (item.studens.Count == 0)
                                {
                                    Helper.Print("Qrupda telebe yoxdur,qrupa student elave edin", ConsoleColor.Red);
                                    goto case 3;
                                }
                                else
                                {
                                    foreach (var item1 in item.studens)
                                    {
                                        Helper.Print($"Id:{item1.Id} AD:{item1.Name}", ConsoleColor.Yellow);
                                    }
                                }

                            }
                        }
                        idd:
                        Helper.Print("Editlemek istediyin student ID qeyd edin", ConsoleColor.Green);
                        string _idd = Console.ReadLine();
                        bool isidd = int.TryParse(_idd, out int idd_);
                        if (!isidd)
                        {
                            Console.WriteLine("Yanlis daxil edildi,Duzgun daxil edin");
                            goto idd;
                        }
                        foreach (var item in course.groups)
                        {
                            foreach (var item1 in item.studens)
                            {
                                if (item1.Id == idd_)
                                {
                                    Helper.Print("Studentin yeni adi ", ConsoleColor.Green);
                                    string newname = Console.ReadLine();
                                    item1.Name = newname;
                                    Helper.Print("Studentin yeni soyadi ", ConsoleColor.Green);
                                    string nsrname = Console.ReadLine();
                                    item1.Surname = nsrname;
                                    AGE:
                                    Helper.Print("Student yeni yasini qeyd edin", ConsoleColor.Green);
                                    string _age = Console.ReadLine();
                                    bool isAge = int.TryParse(_age, out int age);
                                    if (!isAge)
                                    {
                                        Helper.Print("Yanlis daxil edildi,Duzgun daxil edin", ConsoleColor.Red);
                                        goto AGE;
                                    }
                                    item1.Age = age;
                                    GRADE:
                                    Helper.Print("Studentin yeni balini qeyd edin", ConsoleColor.Green);
                                    string _gr = Console.ReadLine();
                                    bool isGrade = int.TryParse(_gr, out int grade);
                                    if (!isGrade)
                                    {
                                        Helper.Print("Yanlis daxil edildi,Duzgun daxil edin", ConsoleColor.Red);
                                        goto GRADE;
                                    }
                                    item1.Grade = grade;
                                    Helper.Print($" Student editlendi ", ConsoleColor.Yellow);
                                    break;
                                }
                                
                            }
                        }
                        break;
                  
                    default:
                        break;
                }


            }

        }
    }
}
