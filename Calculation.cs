class Calculation {
    private double number1;
    private double number2;

    public Calculation(double number1, double number2) {
        this.number1 = number1;
        this.number2 = number2;
    }

    public double GetAddition() {
        return this.number1 + this.number2;
    }

    public double GetSubtraction() {
        return this.number1 - this.number2;
    }

    public double GetMultiplication() {
        return this.number1 * this.number2;
    }

    public double GetDivision() {
        return this.number1 / this.number2;
    }
}