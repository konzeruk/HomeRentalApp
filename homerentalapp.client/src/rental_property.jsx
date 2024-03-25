import React from 'react'
import { BrowserRouter as Router, Route, Link } from "reac"
//import Alert from './alert'

class RentalProperty extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            alertMessage: ""
        };

        this.handleInputChange = this.handleInputChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
        this.setAlertMessage = this.setAlertMessage.bind(this);
    }

    handleInputChange(event) {
        event.preventDefault();

        const target = event.target;

        this.setState({
            [target.name]: target.value
        });
    }

    handleSubmit(event) {
        event.preventDefault();

    }

    setAlertMessage(message) {
        this.setState({ alertMessage: message });
    }

    render() {
        return (
            <div>
                <rout href="https://www.google.ru/" style={{ color: "grey" }}>
                    <form style={{ backgroundColor: "white" }}>
                    
                    <label>ffff</label>
                    </form>
                </rout>
                <form><label>ffff</label></form>
                <form><label>ffff</label></form>
            </div>
        );
    }
}

export default RentalProperty;