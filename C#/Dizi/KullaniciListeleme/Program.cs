using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KullaniciListeleme
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] usernames = new string[10];

            do
            {
                #region Ana Ekran
                Console.Clear();
                Console.WriteLine("----------------------");
                Console.WriteLine(" 1.Kullanıcı Ekle");
                Console.WriteLine(" 2.Kullanıcı Sil");
                Console.WriteLine(" 3.Kullanıcı Güncelle");
                Console.WriteLine(" 4.Listeyi Göster");
                Console.WriteLine(" 5.Çıkış");
                Console.WriteLine("----------------------");

                int secim = int.Parse(Console.ReadLine());
                string username = null;
                int index = 0;
                #endregion
                switch (secim)
                {
                    case 1:
                        #region Kullanıcı Ekle
                        //Eğer boş yer varsa ekleyecek
                        int numOfNullUser = 0;
                        foreach (var user in usernames)
                        {
                            if (user == null)
                            {
                                numOfNullUser++;
                            }
                        }
                        if (numOfNullUser > 0)
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("---Kullanıcı Ekleme Sayfası---");
                                Console.Write("Kullanıcı Adı: ");
                                username = Console.ReadLine();
                                //Böyle Bir Kullanıcı Varmı
                                if (!usernames.Contains(username))
                                {
                                    //ilk boş değeri bulur
                                    index = Array.IndexOf(usernames, null);
                                    usernames.SetValue(username, index);
                                    Console.Clear();
                                    Console.WriteLine("Kayıt Başarılı...");
                                    Console.WriteLine("Başka Bir Kullanıcı eklemek istiyor musunuz (e/h)");
                                }
                                else
                                {
                                    Console.WriteLine("Kayıt Başarısız...");
                                    Console.WriteLine($"{username} isminde başka bir kullanıcı mevcut...");
                                    Console.WriteLine("Tekrar denemek ister misin ? (e/h)");

                                }
                            } while (Console.ReadLine() == "e");


                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Rehber Dolu...");
                            Console.WriteLine("Yönlendiriliyorsunuz...");
                            Thread.Sleep(2000);
                        }
                        break;
                    #endregion

                    case 2:
                        #region Kullanıcı Sil
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("---Kullanıcı Silme Sayfası---");
                            Console.Write("Kullanıcı Adı: ");
                            username = Console.ReadLine();

                            //Böyle Bir Kullanıcı Varmı
                            if (!usernames.Contains(username))
                            {
                                Console.Clear();
                                Console.WriteLine("Silme Başarısız...");
                                Console.WriteLine($"{username} isminde bir kullanıcı yok...");
                                Console.WriteLine("Tekrar denemek ister misin ? (e/h)");
                            }
                            else
                            {
                                index = Array.IndexOf(usernames, username);
                                usernames.SetValue(null, index);
                                Console.Clear();
                                Console.WriteLine("Silme Başarılı...");
                                Console.WriteLine("Başka bir kullanıcı silmek ister misin ? (e/h)");
                            }
                        } while (Console.ReadLine() == "e");
                        #endregion
                        break;

                    case 3:
                        #region Kullanıcı Güncelle
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("---Kullanıcı Güncellme Sayfası---");
                            Console.Write("Kullanıcı Adı: ");
                            username = Console.ReadLine();

                            //Böyle Bir Kullanıcı Varmı
                            if (!usernames.Contains(username))
                            {
                                Console.Clear();
                                Console.WriteLine("Güncellme Başarısız...");
                                Console.WriteLine($"{username} isminde bir kullanıcı yok...");
                                Console.WriteLine("Tekrar denemek ister misin ? (e/h)");
                            }
                            else
                            {
                                Console.Write("Kullanıcı Adı: ");
                                string usernameUpdate = Console.ReadLine();
                                index = Array.IndexOf(usernames, username);
                                usernames.SetValue(usernameUpdate, index);
                                Console.Clear();
                                Console.WriteLine("Güncelleme Başarılı...");
                                Console.WriteLine("Başka bir kullanıcı güncellemek ister misin ? (e/h)");
                            }
                        } while (Console.ReadLine() == "e");
                        #endregion
                        break;
                    case 4:
                        #region Listele
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("----Liste----");
                            foreach (var item in usernames)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine("Çıkmak istiyormusunuz (e/h)");
                        } while (Console.ReadLine() != "e");
                        #endregion

                        break;
                    case 5:
                        //çıkış
                        Environment.Exit(0);
                        break;
                }

            } while (true);
        }

    }
}
