using System;
using System.Text;

class Program {
  public static void Main (string[] args) {
    string alphabet="абвгдеёжзийклмнопрстуфхцчшщъыьэяюАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    
    
    Console.WriteLine("Введите текст");
    
    string text = Console.ReadLine();
    
    Console.WriteLine("Введите шаг");
    
    int step = int.Parse(Console.ReadLine());
    
    
    
    Link1:
    Console.WriteLine("1 для шифрования 2 для дешифрования");
    
    int choice = int.Parse(Console.ReadLine());
    
    StringBuilder ctext = new StringBuilder(text);
    
    if(choice==1)
    {
      for(int i=0; i<=text.Length-1; i++)
   {
        for(int q=0; q<=alphabet.Length-1;q++)
       {
         
         if(text[i]==alphabet[q])
        {
          if(q+step>alphabet.Length-1)
         {
           ctext[i]=alphabet[alphabet.Length-1];
         } 
          else{int n =q+step;          ctext[i]=alphabet[n];} 
        }
       
       }
    }
 } 
    else if(choice==2)
    {
      for(int i=0; i<=text.Length-1; i++)
   {
        for(int q=0; q<=alphabet.Length-1;q++)
       {
        if (text[i]==alphabet[q])
        {
          if(q-step<alphabet.Length-1)
          {
            ctext[i]=alphabet[0];
          }
          else {int n =q-step;          ctext[i]=alphabet[n];} 
        }
       
       }
    }
 } 
    else
    {
    goto Link1;
    } 
    
    Console.WriteLine(ctext);
    
  }
}