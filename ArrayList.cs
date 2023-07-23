public class ArrayList{
    public string[] arr;
    int count = 0;
    public ArrayList(int size)
    {
        arr = new string[size];
    }


    public void set(int index, string value)
    {
        if(index < count)
            arr[index] = value;
    }


    private void Scale()
    {
        //resize the array
        //create new array
        //copy the old element to the new array
        string[] newArr = new string[count*2];
        int newCount = 0;
        foreach(var s in arr)
        {
            newArr[newCount++] = s;
        }
        count = newCount;
        arr = newArr;
    }


    public void add(string str)
    {
        if(count == arr.Length)
        {
             string[] newArr = new string[count*2];
            int newCount = 0;
            foreach(var s in arr)
            {
                newArr[newCount++] = s;
            }
            count = newCount;
            arr = newArr;
        }
        arr[count++] = str;
    }

    // my remove function
    public void remove(int index)
    {
        if (index >= 0 && index < count)
        {
            for (int i = index; i < count - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            count--;
        }
    }


    public void remove(string value)
    {
        int index = search(value);

        if(index != -1)
        {
            for(int i = index; i < count; i++)
            {
                //remove by shiffting
                arr[i] = arr[i+1]; 
            }
            count--;
        }
    }

    // insert method
    public void insert(int index, string value)
    {
       if (index >= 0 && index <= count)
        {
            if (count == arr.Length)
            {
                Scale();
            }

            for (int i = count - 1; i >= index; i--)
            {
                arr[i + 1] = arr[i];
            }

            arr[index] = value;
            count++;
        }
    }
    
    
    public int search(string value)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == value)
            {
                return i;
            }
        }
        return -1;
        //time complexity

    }


    public int Length()
    {
        return count;
    }


    public void print()
    {
        for(int i = 0; i < count; i++)
        {
            Console.WriteLine(arr[i]);
        }
        //time complexity

    }

    static void Main()
    {
        ArrayList arrayList = new ArrayList(3);
        string[] values = { "apple", "banana", "orange" };

        foreach (var item in values)
        {
            arrayList.add(item);
        }

        arrayList.print();

        var index = arrayList.Search("banana");
        System.Console.WriteLine($"Index of banana is: {index}");

        arrayList.Remove(2);

        arrayList.Insert(0, "Watermelon");

        arrayList.print();
    }
}
