using ShapesGenerateSample;

var originalCircle = new Circle("Red", 10);

var cloneCircle=originalCircle.Clone();
cloneCircle.Color = "Blue";
originalCircle.Draw();
cloneCircle.Draw();


var originalRectangle = new Rectangle("Green", 20, 30);


var clonedRectangle = (Rectangle)originalRectangle.Clone();
clonedRectangle.Width = 25;  //change this in cloned


originalRectangle.Draw();  
clonedRectangle.Draw();   


var originalTriangle = new Triangle("Yellow", 15, 25);


var clonedTriangle = (Triangle)originalTriangle.Clone();
clonedTriangle.BaseLength = 20;  


originalTriangle.Draw();  
clonedTriangle.Draw();   