import React from 'react'
import RentalPropertyForm from './rental_property_form.jsx'
//import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';

class RentalProperty extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            codeForms: []
        };

        //TODO:добавить запрос и возврат данных из запроса

        const models = [
            { url: "src/authorization.jsx", name: "name", address: "address", price: 123 },
            { url: "/post/2", name: "name", address: "address", price: 123 },
            { url: "/post/3", name: "name", address: "address", price: 123 }
        ];

        this.createCodeForms(models);
    }

    createCodeForms(models) {
        models.forEach((model) => {
            this.state.codeForms.push(RentalPropertyForm.getNewForm(model),)
        });
    }

    render() {
        return (
            <di>
                {this.state.codeForms}
            </di>
        );
    }
}

export default RentalProperty;