using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace UniversityClasses
{
    [System.Serializable]
    class Universal 
    {
        public static Universal instance;
        static Universal()
        {


            if (instance == null)
            {
                instance = new Universal();
                if (File.Exists("Uni"))
                {
                    FileStream file = File.Open("Uni", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    if (new FileInfo("Uni").Length == 0)
                    {
                        // empty
                        //console.lo
                        RowNode<Manager> newManagerNode = new RowNode<Manager>();
                        newManagerNode.info = new Manager();
                        instance.firstMng = newManagerNode;
                        instance.lastMng = instance.firstMng;
                        bf.Serialize(file, instance);
                        file.Close();
        
                    }
                    else {
                        instance = bf.Deserialize(file) as Universal;
                        file.Close();
        
                    }
                }
                else
                {
                    RowNode<Manager> newManagerNode = new RowNode<Manager>();
                    newManagerNode.info = new Manager();
                    instance.firstMng = newManagerNode;
                    instance.lastMng = instance.firstMng;
                    FileStream file = File.Create("Uni");
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, instance);
                    file.Close();
                  
                }
            }
        }
        public RowNode<Student> firstStd;
        public RowNode<Student> lastStd;

        public RowNode<Master> firstMst;
        public RowNode<Master> lastMst;

        public RowNode<Manager> firstMng;
        public RowNode<Manager> lastMng;

        public Node<Course> firstCrs;
        public Node<Course> lastCrs;
        public bool isAbleUnitChoice = false;
        public bool isAbleUnitEdit = false;
    }
}
