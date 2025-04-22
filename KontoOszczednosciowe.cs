public class KontoOszczednosciowe : KontoBankowe{
    private decimal StopaProcentowa;

    public KontoOszczednosciowe(string imieWlasciciela, int numerKonta, decimal saldo, decimal stopaProcentowa) 
        : base(imieWlasciciela, numerKonta, saldo){
        StopaProcentowa = stopaProcentowa;
    }
    public KontoOszczednosciowe(string imieWlasciciela, int numerKonta, decimal stopaProcentowa) 
        : base(imieWlasciciela, numerKonta, 0){
        StopaProcentowa = stopaProcentowa;
    }
    public KontoOszczednosciowe(string imieWlasciciela, int numerKonta) 
        : this(imieWlasciciela, numerKonta, 0, 0m){
    }
    override public void Wplac(decimal kwota){
        if(kwota > 0){
            saldo += kwota*(1 + StopaProcentowa);
        }
    }
    override public string ZwrocInformacje(){
        return base.ZwrocInformacje() + $", Stopa procentowa: {StopaProcentowa}";
    }
}