/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ndigitintadder;
/**
 *
 * @author hrvoje
 */
public class NDigitIntAdder {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        String result = "";
        
        BigInt number1 = new BigInt("99999999999999999999999999999999999");
        BigInt number2 = new BigInt("99999999999999999999999999999999999");
        
        result = number1.Add(number2);
        
        System.out.println(result);
    }
    
}
