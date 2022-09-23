    public  class Calculator
    {
        private int num1;
        private int num2;
        public Calculator(int a, int b)
        {
            num1 = a;
            num2 = b;
        }
        public  int  Add(int a,int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int div(int a, int b)
        {
            return a / b;
        }
    }
