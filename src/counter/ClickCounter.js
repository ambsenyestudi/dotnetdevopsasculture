import Button from 'react-bootstrap/Button';
import React from 'react';
const ClickCounter = ({ handleClick, children }) =>{
    return (
        
        <div class="row">
            <div class="col-md-4">
                <Button variant="primary" className="btn-primary" size="lg" style={{ minWidth: "300px"}} onClick={handleClick}>{children}</Button>
            </div>        
        </div>);
}
export default ClickCounter;