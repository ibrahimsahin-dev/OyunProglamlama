using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    void bolenleriBul(int ilksayi, int ikincisayi)
    {
        string adding="";
        string doubles = "";
        string triplers = "";
        string quads = "";
        string quintets = "";
        int fark = ikincisayi - ilksayi + 1;
        int[] dizi = new int[fark];
        int i = 0;
        while((ikincisayi-ilksayi)>=i)
        {
            dizi[i] = ilksayi + i;
            i++;
        }

        i = 0;

        while(i<fark)
        {
            adding += "- ";
            adding+=dizi[i] + " ";
            i++;
        }
     
        print("Tüm liste: "+adding);
        i = 0;
        while(i<fark)
        {
            if (dizi[i] % 2 == 0)
                doubles += "- " + dizi[i] + " ";
            i++;
        }
        print("Ýkiye bölünenler: "+doubles);

        i = 0;
        while (i < fark)
        {
            if (dizi[i] % 3 == 0)
                triplers += "- " + dizi[i] + " ";
            i++;
        }
        print("Üçe bölünenler: " +triplers);

        i = 0;
        while (i < fark)
        {
            if (dizi[i] % 4 == 0)
                quads += "- " + dizi[i] + " ";
            i++;
        }
        print("Dörde bölünenler: " + quads);

        i = 0;
        while (i < fark)
        {
            if (dizi[i] % 5 == 0)
                quintets += "- " + dizi[i] + " ";
            i++;
        }
        print("Beþe bölünenler: " + quintets);

    }



    void Start()
    {
        bolenleriBul(20,44);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
