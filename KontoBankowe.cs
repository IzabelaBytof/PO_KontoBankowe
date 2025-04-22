public class KontoBankowe{
    private string ImieWlasciciela;
    private int NumerKonta;
    private decimal Saldo;
    protected decimal saldo{
        get { return Saldo; }
        set { Saldo = value; }
    }
    public KontoBankowe(string imieWlasciciela, int numerKonta, decimal saldo)
    {
        ImieWlasciciela = imieWlasciciela;
        NumerKonta = numerKonta;
        Saldo = saldo;
    }
    public KontoBankowe(string imieWlasciciela, int numerKonta) : this(imieWlasciciela, numerKonta, 0) {

    }
    public virtual void Wplac(decimal kwota){
        if(kwota > 0){
            Saldo += kwota;
        }else{
            Console.WriteLine("Kwota musi być większa od 0.");
        }
    }
    public bool Wyplac(decimal kwota){
        if(kwota > 0 && kwota <= Saldo){
            Saldo -= kwota;
            return true;
        }else{
            Console.WriteLine("Nie można wypłacić tej kwoty.");
            return false;
        }        
    }
    public virtual string ZwrocInformacje(){
        return $"Imię właściciela: {ImieWlasciciela}, Numer konta: {NumerKonta}, Saldo: {Saldo}";
    }
}