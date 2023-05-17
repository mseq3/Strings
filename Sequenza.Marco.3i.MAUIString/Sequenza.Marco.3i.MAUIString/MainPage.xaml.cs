using System.Globalization;
using System.Runtime.ConstrainedExecution;
using static System.Net.Mime.MediaTypeNames;

namespace Sequenza.Marco._3i.MAUIString;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }
    // Metodo per sostituire l'istruzione ".Lenght"
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

    // Metodo per togliere gli spazi
    
    string spazi(string s)
    {
        char[] caratteri = s.ToCharArray();
        int j = 0, conta = 0;

        for (int i = 0; i < Lunghezza(caratteri); i++)
        {
            if (caratteri[i] != ' ') conta++;
        }

        char[] spazi = new char[conta];

        for (int i = 0; i < Lunghezza(caratteri); i++)
        {
            if (caratteri[i] != ' ')
            {
                spazi[j] = caratteri[i];
                j++;
            }
        }

        return new string(spazi);
    }
    

    // Metodo per sostituire l'istruzione ".ToUpper()"
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
    // Metodo per sostituire l'istruzione ".ToLower()"
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

    // Secondo metodo per sostiutire il ToUpper() restituendo un char
     char ToUpper(char c)
    {
        if (c >= 'a' && c <= 'z')
        {
            int a = (int)c & 0xDF;
            return (char)a;
        }
        return c;
    }

    // Secondo metodo per sostiutire il ToLower() restituendo un char

    char ToLower(char c)
    {
        if (c >= 'A' && c <= 'Z')
        {
            int a = (int)c | 0x20;
            return (char)a;
        }
        return c;
    }

    //Conta le lettere
    int lettere(string s)
    {
        char[] caratteri = s.ToCharArray();
        int retVal = 0;

        for (int i = 0; i < Lunghezza(caratteri); i++)
            if ((caratteri[i] >= 'A') && (caratteri[i] <= 'Z') ||
               (caratteri[i] >= 'a') && (caratteri[i] <= 'z'))
                retVal++;

        return retVal;
    }

    //Reverse delle parole
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

    //Controllo dei caratteri alfabetici
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

    //Controllo dei caratteri alfanumerici
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

    
    // Controlla da quante parole è formata
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

    // Capitalizzazione della stringa
    
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

    //Controlla se è palindroma
    
    bool palindroma(string s)
        
    {
        if (spazi(Minuscolo(s)) == spazi(Minuscolo(reverse(s))) && !punte(s)) return true;     
        else return false;
    }
    

    //Controlla se c'è la punteggiatura
    bool punte(string s)
    {
        char[] caratteri = s.ToCharArray();
        for (int i = 0; i < Lunghezza(caratteri); i++)
            if (!((caratteri[i] >= 'a') && (caratteri[i] <= 'z') ||
               (caratteri[i] >= 'A') && (caratteri[i] <= 'Z') ||
               (caratteri[i] >= '0') && (caratteri[i] <= '9') ||
               caratteri[i] == ' '))
            {
                return true;
            }
        return false;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        //Output

        txtMaiuscola.Text = Maiuscolo(edtTesto.Text);
        txtMinuscola.Text = Minuscolo(edtTesto.Text);
        txtlettere.Text = Convert.ToString(lettere(edtTesto.Text));
        txtreverse.Text = reverse(edtTesto.Text);
        txtalfabeto.Text = Convert.ToString(alfabeto(edtTesto.Text));
        txtalfanumerici.Text = Convert.ToString(alfanumerici(edtTesto.Text));
        txtparole.Text = Convert.ToString(parole(edtTesto.Text));
        txtPalindroma.Text = Convert.ToString(palindroma(edtTesto.Text));
        txtCapitalizzata.Text = cap(edtTesto.Text);
    }
}

