# Stringhe
#### Il linguaggio utilizzato in questo codice è il C#
>  Questo programma è sviluppato per lo studio delle stringhe
  
  #  **Descrizione:**
  Realizzazione di un app MAUI  per  lo **studio delle stringhe**  ASCII 7 bit (non unicode).
  
  Dobbiamo immaginare di programmare con un linguaggio privo delle facility date dagli oggetti String come ad esempio il linguaggio **C**.
  
  **NON  SI POSSONO ** quindi utilizzare le seguenti classi/metodi di **manipolazione delle stringhe** tipiche dei linguaggi C#,C++,Pyton.
  
  Esempi:
  
 StringBuilder, ToUpper(), ToLower(), Count(), Lenght(), Replace(), IsLetter(), IsNumber() etc...
 
 #  **Finalità del programma:**
 
 Questo programma serve per consolidare
 
 *    l'uso dei vettori
 
 *  l'uso dei cicli (for, do, while)
 
 *   l'uso della mascheratura dei bit con operatori logici and, or, xor, not su dati interi
 
 *  l'uso dei metodi
 
 *  la tabella ASCII
 
 *   il pensiero computazionale, gli algoritmi di ordinamento
 
# **  Cosa si ottiene da questo programma:**

* Versione **maiuscola** delle stringhe

*  versione   **minusciola** delle stringhe

*  se contiene solo **caratteri alfabetici**

*   Di    **quante lettere** è formata

*  se contiene solo caratteri  **alfanumerici**

*   La sua versione **rovesciata**

# **Metodi utilizzati:**

``` 
int Lunghezza(string s)
    {
        char[] caratteri = s.ToCharArray();
        return Lunghezza(caratteri);
    }
    int Lunghezza(char[] caratteri)
    {
        int retVal = 0;
        foreach (char carattere in caratteri)
        {
            retVal++;
        }
        return retVal;
    }
``` 

> questo metodo è utilizzato per sostituire "**Length()**; utilizzato per contare i caratteri.

``` 
 string Maiuscolo(string s)
    {
        int len = Lunghezza(s);
        char[] caratteri = s.ToCharArray();
        for (int idx = 0; idx < len; idx++)
        {
            if ((((int)caratteri[idx]) & 0x40) != 0)
            {
                int a = (int)caratteri[idx] & 0x5f;
                caratteri[idx] = (char)a;
            }
        }
        return new string(caratteri);
    }
``` 

> Questo metodo è utilizzato per sostituire  il "**ToUpper()**", utilizzato per convertire le stringhe in maiuscolo.

``` 
string Minuscolo(string s)
    {
        int len = Lunghezza(s);
        char[] caratteri = s.ToCharArray();
        for (int idx = 0; idx < len; idx++)
        {
            if ((((int)caratteri[idx]) & 0x40) != 0)
            {
                int a = (int)caratteri[idx] | 0x20;
                caratteri[idx] = (char)a;
            }
        }
        return new string(caratteri);
    }
``` 

> Questo metodo è utilizzato per sostituire il "**ToLower()**", utilizzato per convertire le stringhe in minuscolo.

``` 
int lettere(string s)
    {
        char[] caratteri = s.ToCharArray();
        int retVal = 0;

        for (int i = 0; i < Lunghezza(caratteri); i++)
            if ((caratteri[i] >= 'A') && (caratteri[i] <= 'Z') ||
               (caratteri[i] >= 'a') && (caratteri[i] <= 'z'))
                retVal++;

        return retVal;
``` 
> Questo metodo è utilizzato per sostituire il






    


 

  
 
 
  
  




