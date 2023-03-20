
public class DArray
{
    private int capacity;
    private double[] Arr;
    public int Size { get; private set; }
    public int Capacity { get { return capacity; } }

    public DArray()
    {
        Arr = Array.Empty<double>();
        capacity = 0;
        Size = 0;
    }
    public DArray(int capacity)
    {
        this.capacity = capacity;
        Arr = new double[capacity];
        Size = 0;
    }
    public DArray(double[] arr)
    {
        capacity = arr.Length*2;
        Size = arr.Length;
        Arr = new double[capacity];
        arr.CopyTo(Arr, 0);
    } 
    public double ReadElem(int index) 
    { return Arr[index]; }
    public void WriteElem(int i, double value) { Arr[i] = value; }
    public override string ToString()
    {
        string array = "";
        for (int i = 0; i < Size; i++) { array = array + Arr[i] + " "; }
        return array;
    }
    private void CapacityPlus()
    {
        if (Size == capacity)
        {
            double[] temp = new double[capacity];
            Arr.CopyTo(temp,0);
            if (Size != 0) capacity *= 2;
            else capacity = 1;
            Arr = new double[capacity];
            temp.CopyTo(Arr,0);

        }
    }

    public void CapacityMinus() 
    {
        if (Size == capacity) 
        {
            capacity /= 2;
            Arr = new double[capacity]; 
            double[] temp = new double[capacity];
            Array.Copy(Arr, temp, capacity);
            temp.CopyTo(Arr, 0);
            
        }
       
    }
   public void AddElemEnd(double value)
    {
        CapacityPlus();
        Arr[Size++] = value;
    }
    public void RemoveElemEnd()
    {
        Size--;
        CapacityMinus();
    }
    public void AddInd(double elem, int index)
    { CapacityPlus();
        for (int i = Size++; i > index; i--)
            Arr[i] = Arr[i - 1];
        Arr[index] = elem;
    }
    public void RemoveInd(int index)
    {
        for (int i = index; i < Size - 1; i++)
            Arr[i] = Arr[i + 1];
        Size--;
        CapacityMinus();
    }
    public int MaxInd()
    {
        int index = 0;
        for (int i = 1; i < Size; i++)
        {
            if (Arr[i] > Arr[index]) index = i;
        }
        return index;
    }

}
