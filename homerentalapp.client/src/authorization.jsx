import React from 'react'
import Alert from './alert'
//import sendRequest from './send_request'
import './authorization.css'

class Authorization extends React.Component{
    constructor(props) {
        super(props);

        this.state = {
            login: "",
            password: "",
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

        this.setAlertMessage();

        if (this.state.login === 0 || this.state.password.length === 0)
            return this.setAlertMessage("Login or password not enter");

        const data = {};

        data["login"] = this.state.login;
        data["password"] = this.state.password;

        //TODO доделать отправку формы дальше
        //sendRequest("", data)
    }

    setAlertMessage(message) {
        this.setState({ alertMessage: message });
    }

    render() {
        return (
            <div>
                <form onSubmit={this.handleSubmit}>
                    <label>
                        Login
                        <br/>
                        <input
                            className="input"
                            name="login"
                            type="text"
                            value={this.state.login}
                            onChange={this.handleInputChange}
                        />
                    </label>

                    <br />

                    <label>
                        Password
                        <br />
                        <input
                            className="input"
                            name="password"
                            type="password"
                            value={this.state.password}
                            onChange={this.handleInputChange}
                        />
                    </label>

                    <br />

                    <Alert message={this.state.alertMessage} /> 

                    <br />

                    <button type="submit">Log in</button>
                </form>
            </div>
        );
    }
}

export default Authorization;