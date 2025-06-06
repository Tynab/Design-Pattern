using Composite;
using static System.Console;

var client = new Client();
var leaf = new Leaf();

WriteLine("Client: I get a simple component:");

client.ClientCode(leaf);

var tree = new Composite.Composite();
var branch1 = new Composite.Composite();

branch1.Add(new Leaf());

var branch2 = new Composite.Composite();

branch2.Add(new Leaf());
tree.Add(branch1);
tree.Add(branch2);

WriteLine("Client: Now I've got a composite tree:");

client.ClientCode(tree);

Write("Client: I don't ned to check the components classes even when managing the tree:\n");

client.ClientCode(tree, leaf);

/*
 * Client: I get a simple component:
 * RESULT: Leaf
 * 
 * Client: Now I've got a composite tree:
 * RESULT: Branch(Branch(Leaf+Leaf)+Branch(Leaf))
 * 
 * Client: I don't need to check the components classes even when managing the tree:
 * RESULT: Branch(Branch(Leaf+Leaf)+Branch(Leaf)+Leaf)
*/
