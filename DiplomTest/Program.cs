    public class Beregning {
        static void Main(string[] args) {

        }
        
        // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
        public double SkatVedJulegave(double julegave, double andenGave) {
            double skat = 0;
            // julegaver over 1200 skal beskattes
            if(julegave >1200 ) skat = 1200 + andenGave;

            // samlet beløb over 1200 men julegave på 900 eller under beskattes ikke 
            else if(julegave + andenGave > 1200) {
                if(julegave <= 900) skat = andenGave;
                // hvis julegaven er over 900 beskattes det fulde beløb
                else skat = julegave + andenGave;
                }

            // julegave på 1200 men ingen andre gaver beskattes ikke.
            else if(julegave <=1200 && andenGave == 0) return skat;

            return skat;
        }
    }