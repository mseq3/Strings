# Stringhe
#### Il linguaggio utilizzato in questo codice è il C#
>  Questo programma è sviluppato per lo studio delle stringhe
  
  #  **Descrizione:**
  Realizzazione di un app MAUI  per  lo **studio delle stringhe**  ASCII 7 bit (non unicode).
  
  Dobbiamo immaginare di programmare con un linguaggio privo delle facility date dagli oggetti String come ad esempio il linguaggio **C**.
  
  **NON  SI POSSONO** quindi utilizzare le seguenti classi/metodi di **manipolazione delle stringhe** tipiche dei linguaggi C#,C++,Pyton.
  
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
 
# **Cosa si ottiene da questo programma:**

* Versione **maiuscola** delle stringhe

*  versione   **minusciola** delle stringhe

*  se contiene solo **caratteri alfabetici**

*   Di    **quante lettere** è formata

*  se contiene solo caratteri  **alfanumerici**

*   La sua versione **rovesciata**

* Di **quante parole** è formata

* La sua versione **capitalizzata**

* Se la stringa è **palindroma**

# **Metodi utilizzati:**

```C# 
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

```C# 
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

> Questo metodo è utilizzato per sostituire  il "**ToUpper()**", utilizzato per convertire le stringhe in maiuscolo (Esempio: 'ciao' ---> 'CIAO').

```C# 
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

> Questo metodo è utilizzato per sostituire il "**ToLower()**", utilizzato per convertire le stringhe in minuscolo (Esempio: 'cIaO' ---> 'ciao').

```C#
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
> Questo metodo è utilizzato per vedere da **quante lettere** è formata la stringa.

```C#
string reverse(string s)
    {
        char[] caratteri = s.ToCharArray();
        char[] reverse = new char[Lunghezza(caratteri)];


        for (int i = 0; i < Lunghezza(s); i++)
        {
            reverse[i] = (char)caratteri[Lunghezza(caratteri) - i - 1];
        }

        return new string(reverse);
    }
``` 
> Questo metodo è utilizzato per **rovesciare** la stringa (Esempio: 'Ciao' ---> 'oaiC').

```C# 
bool alfabeto(string s)
    {
        char[] caratteri = s.ToCharArray();
        for (int i = 0; i < Lunghezza(caratteri); i++)
            if (!((caratteri[i] >= 'a') && (caratteri[i] <= 'z') ||
               (caratteri[i] >= 'A') && (caratteri[i] <= 'Z')))
            {
                return false;
            }

       return true;
      
    }
``` 
> Questo metodo è utilizzato per controllare se la stringa è formata **SOLO** da caratteri **alfabetici** (Esempio: 'ciaoo' = True ---> 'ciao12' = False).

```C# 
bool alfanumerici(string s)
    {
        char[] caratteri = s.ToCharArray();
        for (int i = 0; i < Lunghezza(caratteri); i++)
            if (!((caratteri[i] >= 'a') && (caratteri[i] <= 'z') ||
               (caratteri[i] >= 'A') && (caratteri[i] <= 'Z') ||
               (caratteri[i] >= '0') && (caratteri[i] <= '9')))
            {
                return false;
            }
        return true;
    }
``` 
> Questo metodo è utilizzato per controllare se la stringa è formata da caratteri **alfanumerici** (Esempio: 'ciao233' = True ---> 'ciao244!' = False).

```C#
bool punte(string s)
    {
        char[] caratteri = s.ToCharArray();
        for (int i = 0; i < Lunghezza(caratteri); i++)
            if (!((caratteri[i] >= 'a') && (caratteri[i] <= 'z') ||
               (caratteri[i] >= 'A') && (caratteri[i] <= 'Z') ||
               (caratteri[i] >= '0') && (caratteri[i] <= '9')))
            {
                return true;
            }
        return false;
    }
``` 
> Questo metodo è utilizzato per sostituire il "**Char.IsPunctuation()**", utilizzato per controllare se nella stringa è presente un segno di punteggiatura.

```C#
 string cap(string s)
    {
        char[] caratteri = Minuscolo(s).ToCharArray();
        
        if((Lunghezza(caratteri) != 0) && (caratteri[0] >= 'a') && (caratteri[0] <= 'z'))
        {
            char primalettera = ToUpper(caratteri[0]);
            caratteri[0] = primalettera;
        }

        for(int i = 0; i <  Lunghezza(caratteri)-1; i++)
        {
            if (((caratteri[i+1] >= 'a') && (caratteri[i+1] <= 'z')) && caratteri[i] == ' ')
            {
                char letteremaiu = ToUpper(caratteri[i+1]);
                caratteri[i+1] = letteremaiu;
            }
        }

        return new string(caratteri);
    }
```
> Questo pezzo di codice trasforma in maiuscolo la prima lettera di ogni parola. Inizialmente traformiamo la stringa in un array di caratteri e la convertiamo in minuscolo. La 1° condizione serve a trasformare il primo carattere in maiuscolo SE il carattere è una lettera e la lunghezza è diversa da zero. Il for serve per scorrere gli elementi del vettore eccetto l'ultimo e viene controllato se il carattere successivo è compreso tra 'a' e 'z' e se il carattere corrente è uno spazio: se entrambe le condizioni sono vere, il carattere successivo viene convertito in maiuscolo.

```C#
  bool palindroma(string s)
        
    {
        if (spazi(Minuscolo(s)) == spazi(Minuscolo(reverse(s))) && !punte(s)) return true;     
        else return false;
    }

```
> Controlla se una parola o una frase è palindroma (cioè la frase o la parola letta al contrario rimane invariata Es. anna). Per far ciò basta convertire la stringa in minuscolo e togliere gli spazi e confrontarla con la stessa stringa posta al contrario, la seconda condizione è che non ci devono essere segni di punteggiatura: se le due condizioni sono vere, la stringa è PALINDROMA.

```C#
int parole(string s)
    {
        char[] caratteri = s.ToCharArray();
        int conta = 0;
        for (int i = 0; i < Lunghezza(caratteri); i++)
        {
            if (caratteri[i] != ' ' && i==0  || caratteri[i] != ' ' && caratteri[i - 1] == ' ')
            conta++;
        }
        return conta;
    }
```
> Questa funzione conta le parole presenti in una stringa. Per fare questa funzione basta utilizzare un for al cui interno vi è un if dove viene eseguito un controllo per verificare se il carattere non è uno spazio e se "i" è uguale a 0, il che significa che è il primo carattere della stringa o se il carattere precedente è uno spazio, il che significa che il carattere è il primo carattere di una nuova parola. Se una di queste condizioni è vera viene incrementata la variabile conta.





    


 

  
 
 
  
  




