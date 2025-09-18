function MouseEvent(){
    return (
        <>
            <div style = {{
                background:"black",
                color: "red",
                padding: "50px"
            }} 
            onMouseEnter={() => {console.log("mouse entered div")}}
            onMouseLeave={() => console.log("mouse left the div")}
            >
                welcome to Mouse Event
            </div>
        </>
    )
}

export default MouseEvent