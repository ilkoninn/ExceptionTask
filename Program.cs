

using ConsoleApp7.Exceptions;
using ConsoleApp7.Models;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Human human = new Human("Ilkin", "Rajabov", 18);
                Human human1 = new Human("Miraga", "Eliyev", 28);
                Human human2 = new Human("Tunay", "Huseynli", 20);
                Human human3 = new Human("Fidan", "Alizade", 19);

                Human[] humans = {human, human1, human2, human3 };

                Console.Write("Please, enter a name for search: ");
                string userName = Console.ReadLine().ToLower();
                
                bool checkUser = false;
                Human user = null;
                for (int i = 0; i < humans.Length; i++)
                {
                    if (humans[i].Name.ToLower() == userName)
                    {
                        checkUser = true;
                        user = humans[i];
                        break;
                    }
                }
                if (checkUser)
                {
                    Console.WriteLine("\n=== User Information ===\n" +
                          $"Name: {user.Name}\nSurname: {user.Surname}\nAge: {user.Age}");

                }
                else
                {
                    throw new DataNotFoundException("There is no such a person!");
                }
                
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DataNotFoundException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
