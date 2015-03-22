/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dijeljenjebezdijeljenja;

/**
 *
 * @author hrvoje
 */
public class DijeljenjeBezDijeljenja {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int brojnik = 24;
        int nazivnik = 7;
        int cjelobrojno = 0;
        int decimalno = 0;
        int cjelobrojnoOstatak = 0;
        StringBuilder ostatak = new StringBuilder();
        
        while(brojnik - nazivnik > 0){
            brojnik = brojnik - nazivnik;
            decimalno = brojnik;
            cjelobrojno++;
        }
        
        // To six decimals
        // TODO: rounding last decimal
        while(decimalno > 0 && ostatak.length() <= 5){
            brojnik = decimalno + decimalno + decimalno + decimalno + decimalno + decimalno
                + decimalno + decimalno + decimalno + decimalno;
        
        decimalno = 0;
        cjelobrojnoOstatak = 0;
        while(brojnik - nazivnik >= 0){
            brojnik = brojnik - nazivnik;
            decimalno = brojnik;
            cjelobrojnoOstatak++;
        }
        
        ostatak.append(Integer.toString(cjelobrojnoOstatak));
        }
        
        System.out.println("Rezultat: " + cjelobrojno + "." + ostatak.toString());
    }
}
