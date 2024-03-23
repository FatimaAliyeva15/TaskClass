namespace TaskClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();

            bool check = true;

            do 
            {

                Console.WriteLine("Menu:");
                Console.WriteLine("1. Employee elave et");
                Console.WriteLine("2. Bütün işçilere bax");
                Console.WriteLine("3. Maaş aralığına göre işçileri axtarış et");
                Console.WriteLine("0. Proqramı bitir");

                Console.Write("Sechim edin: ");
                int sechim = Convert.ToInt32(Console.ReadLine());

                //string sechimStr = "";
                //byte sechim;

                //do
                //{
                //    Console.Write("Sechim edin: ");
                //    sechimStr = Console.ReadLine();
                //} while (!byte.TryParse(sechimStr, out sechim));

                if (sechim == 1)
                {
                    Console.WriteLine("Employee elave et");
                    Console.Write("Isci adi daxil et: ");
                    string name = Console.ReadLine();

                    Console.Write("");
                    Console.Write("Isci soyadi daxil et: ");
                    string surname = Console.ReadLine();

                    Console.Write("");
                    string ageStr = "";
                    byte age;
                    do
                    {
                        Console.Write("Isci yashini daxil et: ");
                        ageStr = Console.ReadLine();
                    }while(!byte.TryParse(ageStr, out age));
    
                    Console.Write("");
                    Console.Write("Isci department adi daxil et: ");
                    string departmentname = Console.ReadLine();

                    Console.Write("");
                    string salaryStr = "";
                    double salary;
                    do
                    {
                        Console.Write("Isci maashini daxil et: ");
                        salaryStr = Console.ReadLine();
                    } while (!double.TryParse(salaryStr, out salary));

                    Employee employee = new Employee(name, surname, age, departmentname, salary);

                    department.AddEmployee(employee);
                    
                }

                else if (sechim == 2)
                {
                    Console.WriteLine("Bütün işçilere bax");
                    department.ShowEmployeeInfo();
                    
                }

                else if(sechim == 3)
                {
                    Console.WriteLine("Maaş aralığına göre işçileri axtarış et");

                    //Console.Write("Minimum maash: ");
                    //double minsalary = Convert.ToDouble(Console.ReadLine());

                    string minStr = "";
                    double minsalary;
                    do
                    {
                        Console.Write("Minimum maash: ");
                        minStr = Console.ReadLine();
                    } while (!double.TryParse(minStr, out minsalary));

                    //Console.Write("Maksimum maash: ");
                    //double maxsalary = Convert.ToDouble(Console.ReadLine());

                    string maxStr = "";
                    double maxsalary;
                    do
                    {
                        Console.Write("Maksimum maash: ");
                        maxStr = Console.ReadLine();
                    } while (!double.TryParse(maxStr, out maxsalary));


                    Employee[] employyesSalary = department.GetAllEmployeesBySalary(minsalary, maxsalary);


                    bool test = false; 

                    for(int i = 0; i < employyesSalary.Length; i++)
                    {
                        Console.WriteLine($"{employyesSalary[i].Name} {employyesSalary[i].Surname}");
                        test = true;
                    }
                    if (!test)
                    {
                        Console.WriteLine("Bu araliqda maash alan isci yoxdur");
                    }

                }
                
                else if(sechim == 0)
                {
                    Console.WriteLine("Proqram bitdi");
                    check = false;
                    break;
                }

                else
                {
                    Console.WriteLine("Duzgun sechim edin");
                    
                }

            }while(check);

        }
    }
}

