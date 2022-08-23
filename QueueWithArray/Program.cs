using QueueWithArray;

var queue = new Queue(4);


queue.Enqueue(5);
queue.Enqueue(90);
queue.Enqueue(44);

queue.Dequeue();
queue.Enqueue(44);

queue.Dequeue();


Console.WriteLine("_______________________");
queue.Print();