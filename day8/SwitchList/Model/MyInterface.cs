namespace ListInterface.Model
{
    public interface MyInterface
    {
        public void addEmp(MyClass obj);

        public void dispEmp(MyClass obj);

        public MyClass EmpSearch(int EmpID);
    }
}