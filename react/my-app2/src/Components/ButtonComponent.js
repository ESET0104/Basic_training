function ButtonComponent()
{
    const buttonHandler = () => {
 
  console.log("Hello World");
  };
 
  return (
    <>
    <button onClick={buttonHandler}>Click me</button>
    </>
  );
}

export default ButtonComponent;