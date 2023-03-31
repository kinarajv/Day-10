
class Program
{
	static void Main() 
	{
		PatientQueue pq = new PatientQueue();
		pq.Enqueue(new Patient("John", 1));
		pq.Enqueue(new Patient("Mary", 2));
		pq.Enqueue(new Patient("Peter", 3));
		List<Patient> pqe = pq.ToList();
		
		foreach(Patient p in pqe)
		{
			Console.WriteLine(p.Name + " " + p.Priority);
		}
	}
}

class PatientQueue
{
	private Queue<Patient> patients = new Queue<Patient>();
	
	public void Enqueue(Patient patient)
	{
		patients.Enqueue(patient);
	}
	
	public List<Patient> ToList()
	{
		return patients.ToList();
	}
}

class Patient 
{
	public string Name { get; set; }
	public int Priority { get; set; }
	
	public Patient(string name, int priority)
	{
		Name = name;
		Priority = priority;
	}
}