/*
146. LRU Cache
save to favorite

    Total Accepted: 95087
    Total Submissions: 599938
    Difficulty: Hard
    Contributors: Admin

Design and implement a data structure for Least Recently Used (LRU) cache. It should support the following operations: get and set.

get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
set(key, value) - Set or insert the value if the key is not already present. When the cache reached its capacity, it should invalidate the least recently used item before inserting a new item.

*/

public class LRUCache {
	private Dictionary<int, Node> dic = new Dictionary<int, Node>();
	private int capacity; Node head; Node tail;
	private int current = 0;
	public LRUCache(int capacity)
	{
		this.capacity = capacity;
	}

	public int Get(int key)
	{
		if (dic.ContainsKey(key))
		{
			var val = dic[key].val;
			Set(key, dic[key].val);
			return val;
		}

		return -1;
	}

	public void Set(int key, int value)
	{
		if (capacity == 0) return;
		if (dic.ContainsKey(key)) // Set the key to head. Most recently used
		{
			var temp = dic[key]; // make a copy of the Node
            temp.val = value;
			// basically we are deleting this node and adding it as the new head. 
            if (temp == head)
			{
				// DO nothing
			}
			else
			{
				if (temp == tail)
				{
					dic[key].prev.next = null;
					tail = dic[key].prev;
				}
				else
				{
					dic[key].prev.next = dic[key].next;
					dic[key].next.prev = dic[key].prev;
				}

				// Now make the copy as the new head. 
                temp.next = head;
				temp.prev = null;
				head.prev = temp;
				// it was previously null, now it's temp, because head will become the second element.
                head = temp;
				dic[key] = head;
			}
		}
		else
		{
			var node = new Node(value);
			dic.Add(key, node);
			if (current < capacity) // simply add to the list. 
			{
				if (current == 0)
				{
					head = node; head.prev = null; head.next = null;
				}

				// Add the second element at the top of the list, as the new //element and make the previous element as tail.
				else if (current == 1)
				{
					tail = head; tail.prev = node; tail.next = null;
					node.next = tail; node.prev = null; head = node;
				}
				else
				{
					node.next = head;
					node.prev = null;
					head.prev = node;
					head = node;
				}

				current++;
			}
			else // Max capacity has been reached. We need to remove the tail and //make the new node as the head.
			{
				if (capacity == 1)
				{
					var headKey = dic.FirstOrDefault(x => x.Value == head).Key;
					dic.Remove(headKey);
					head = node; head.next = null; head.prev = null;
				}
				else
				{
					// make this node the new head
                    node.next = head;
					node.prev = null;
					head.prev = node;
					head = node;

					// Remove tail
                    var tailKey = dic.FirstOrDefault(x => x.Value == tail).Key;
					dic.Remove(tailKey);
					tail = tail.prev;
					tail.next = null;
				}
			}
		}
	}
}

public class Node
{
	public int val;
	public Node prev;
	public Node next;
	public Node(int x)
	{
		val = x;
	}
}