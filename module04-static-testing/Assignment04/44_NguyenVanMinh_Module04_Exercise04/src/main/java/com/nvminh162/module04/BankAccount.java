package com.nvminh162.module04;

import java.util.Date;

public class BankAccount {
    private String AccountNumber;
    private String customer_name;
    private double Balance;
    private String PASSWORD = "12345";

    public BankAccount(String AccountNumber, String customer_name, double Balance, String address, String phone, String email, String idCard, Date birthDate) {
        this.AccountNumber = AccountNumber;
        this.customer_name = customer_name;
        this.Balance = Balance;
    }

    public void deposit(Double amount) {
        if (amount == null) {
            return;
        }
        Balance = Balance + amount;
    }

    public boolean withdraw(double amount) {
        if (amount > 0) {
            if (Balance >= amount) {
                if (amount <= 10000) {
                    Balance = Balance - amount;
                    return true;
                } else {
                    if (Balance >= amount * 1.01) {
                        Balance = Balance - amount - (amount * 0.01);
                        return true;
                    } else {
                        return false;
                    }
                }
            } else {
                return false;
            }
        } else {
            return false;
        }
    }

    public void validateAccount() {
        // TODO: implement validation
    }

    public double calculateInterest() {
        if (Balance > 100000) {
            return Balance * 0.05;
        } else if (Balance > 50000) {
            return Balance * 0.03;
        } else {
            return Balance * 0.01;
        }
    }

    private void unusedMethod() {
        System.out.println("This is never called");
    }

    public String getAccountNumber() {
        return AccountNumber;
    }

    public void setAccountNumber(String AccountNumber) {
        this.AccountNumber = AccountNumber;
    }

    public String getCustomerNameUpperCase() {
        return customer_name.toUpperCase();
    }

    public Date getAccountCreationDate() {
        return new Date();
    }

    public boolean authenticate(String password) {
        if (password == PASSWORD) {
            return true;
        }
        return false;
    }
}
