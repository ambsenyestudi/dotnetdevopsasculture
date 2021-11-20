import Button from 'react-bootstrap/Button';
import React, {useState, useEffect} from 'react';
import axios from 'axios';
const ClickCounter = () => {
    const countUrl = process.env.REACT_APP_CLICK_COUNTER_API_URL + '/' + process.env.REACT_APP_COUNT_ENDPOINT;
    const [message, setMessage] = useState('Loading');
    const [count, setCount] = useState(0);
    console.log(process.env);
    const updateMessage = () =>{
        setMessage("You clicked "+count);
    }

    useEffect(() => {
        var fetchDate = async () =>{
            var response = await axios(countUrl);
            var count = response.data;
            setCount(count.total);
            updateMessage();
        };
        fetchDate();
    });
    
    const handleClick = () => {
        setMessage("Loading...");
        var updateData = async () => {
            var response = await axios.put(countUrl);
            var count = response.data;
            setCount(count.total);
            updateMessage();
        }
        
        updateData();
    }

    return (
        <div class="row">
            <div class="col-md-4">
                <p style={{ minWidth: "300px"}}>{message}</p>
                <Button variant="primary" className="btn-primary" size="lg" style={{ minWidth: "300px"}} onClick={handleClick}>Click me</Button>
            </div>        
        </div>);
}
export default ClickCounter;