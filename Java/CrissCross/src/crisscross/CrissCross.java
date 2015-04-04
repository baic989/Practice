/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package crisscross;

import java.util.Scanner;

/**
 *
 * @author hrvoje
 */
public class CrissCross {
    static Scanner input = new Scanner(System.in);
    static String[][] gameMatrix = new String[3][3];
    static String humanSymbol = "o";
    static String computerSymbol = "x";
    
    public static void main(String[] args) {
        fillGameMatrix();
        humanTurn();
    }

    private static void humanTurn() {
        drawBoard();
        humanPlay();
        
        if(!isGameOver())
        {
            computerTurn();
        }
        else{
            System.out.println("YOU WON! :)");
        }
    }

    private static void computerTurn() {
        drawBoard();
        computerPlay();
        
        if(!isGameOver())
        {
            humanTurn();
        }
        else{
            System.out.println("YOU LOST! :(");
        }
    }

    private static void drawBoard() {
        System.out.println("\n-------");
        
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                System.out.print("|" + gameMatrix[i][j]);
            }
            System.out.print("|");
            System.out.println("\n-------");
        }
        
        System.out.println("\n\n\n");
    }

    private static void humanPlay() {
        int x, y;
        
        System.out.println("Enter your move (x, y): ");
        x = input.nextInt();
        y = input.nextInt();
        
        if(gameMatrix[x][y] == " "){
            gameMatrix[x][y] = humanSymbol;
        }
    }
    
    private static void computerPlay() {
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                if(gameMatrix[i][j] == " "){
                    gameMatrix[i][j] = computerSymbol;
                    
                    return;
                }
            }
        }
    }

    private static boolean isGameOver() {
        return isDiagonal() || isColumn() || isRow();
    }

    private static void fillGameMatrix() {
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                gameMatrix[i][j] = " ";
            }
        }
    }

    private static boolean isDiagonal() {
        if((gameMatrix[0][0] == "x" && gameMatrix[1][1] == "x" && gameMatrix[2][2] == "x") ||
                (gameMatrix[0][0] == "o" && gameMatrix[1][1] == "o" && gameMatrix[2][2] == "o")){
            return true;
        }
        else if((gameMatrix[0][2] == "x" && gameMatrix[1][1] == "x" && gameMatrix[2][0] == "x") ||
                (gameMatrix[0][2] == "o" && gameMatrix[1][1] == "o" && gameMatrix[2][0] == "o")){
            return true;
        }
        
        return false;
    }

    private static boolean isColumn() {
        int xCounter = 0;
        int oCounter = 0;
        
        for(int i = 0; i < 3; i++){
            xCounter = 0;
            oCounter = 0;
            
            for(int j = 0; j < 3; j++){
                if(gameMatrix[j][i] == "x")
                    xCounter++;
                if(gameMatrix[j][i] == "o")
                    oCounter++;
            }
            
            if(xCounter == 3 || oCounter == 3)
                return true;
        }
        
        return false;
    }

    private static boolean isRow() {
        int xCounter = 0;
        int oCounter = 0;
        
        for(int i = 0; i < 3; i++){
            xCounter = 0;
            oCounter = 0;
            
            for(int j = 0; j < 3; j++){
                if(gameMatrix[i][j] == "x")
                    xCounter++;
                if(gameMatrix[i][j] == "o")
                    oCounter++;
            }
            
            if(xCounter == 3 || oCounter == 3)
                return true;
        }
        
        return false;
    }
}
