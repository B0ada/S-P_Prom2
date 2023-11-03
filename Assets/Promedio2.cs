using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Promedio2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Bloque1
        {//1. escribir todos los numeros del N al 1
            int valor1 = 10;
            for (int i = 10; i >= 1; i--)
            {
                Debug.Log(i);
                valor1--;
            }
        }
        {
            //2. escribir la suma de todos los numeros del 1 al N
            int suma = 0;
            for (int i = 1; i <= 10; i++)
            {
                suma += i;
                Debug.Log("esto suma= " + suma);
            }
        }
        {
            //3. Escribir la tabla de multiplicar de un numero 
            int multiplicar = 1;
            for (int i = 1; i <= 10 ; i++)
            {
                Debug.Log("1 *" + i + "="+ multiplicar);
                multiplicar *= 1;
            }
        }
        {
            //4. escribir la potencia de un numero
            int x = 1;
            int contador = 0;
            for (int i = 1; i < 10; i++)
            {
                x *= 2;
                contador++;
            }
        }
        {
            //5.escribir el factorial de un numero
            int factorial = 1;
            for (int i = 1; i < 1246; i++)
            {
                factorial *= i;
                Debug.Log("El factorial" + 1246 + factorial);
            }
        }
        {
            //6. escribir la serie Fibonacci de N terminos 
            int a = 0;
            int b = 1;
            int c;
            for (int i = 0; i < 10 ; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Debug.Log(c);
            }
        }
        //Bloque2

        {
            //1. crear y rellenar con valores random un arreglo de longitud 9999
            int[] s = new int[9999];
            for (int i = 0;i <s.Length; i++)
            {
                s[i] = Random.Range(-100, 100);
                Debug.Log(s[i]);
            }

        }
        {
            //2. Escribir solo los elementos negativos de un arreglo
            int[] q = new int[14];
            for (int i = 0; i < q.Length; i++)
            {
                q[i] = Random.Range(-20, 14);
                if (q[i] < 0)
                {
                    Debug.Log(q[i]);
                }
            }

        }
        {
            //3. escribir la cantidad de elementos impares de un arreglo
            int[] h = { -42, 12, -4, 123, 17, -9, 54, -98 };
            int impares = 0;
            for (int i = 0; i < h.Length; i++)
            {
                if (h[i] % 2 != 0)
                {
                    impares++;
                }
            }
            Debug.Log("los impares son= " + impares);

        }
        {
            //4. teniendo un arreglo de N numeros, insertar un elemento en la posicion N+1
            int[] m = { 1, 5, 12, 14, 26, 37 }; //5 - 6
            int[] k = new int[7];
            for (int i = 0; i < m.Length; i++)
            {
                k[i] = m[i];
            }
            k[6] = 463;

        }
        {
            //5. Escribir la frecuencia de un numero en un arreglo

        }
        {
            //6. invertir un arreglo
            int[] n = { 12, 16, 32, 98 };
            for (int i = 0;i < n.Length; i++)
            {

            }
            
        }
        {
            //7. juntar dos arreglos en uno solo
            int[] j = new int[12];
            int[] r = new int[6];
            int[] s = new int[j.Length+ r.Length];
            for(int i = 0; i < j.Length; i++)
            {
                r[i] = j[i];
            }
            for (int i = 0; i < r.Length; i++)
            {
                s[i + r.Length] = r[i];
            }
            Debug.Log(s);
        }

    }
}
