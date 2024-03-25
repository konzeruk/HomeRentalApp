class RentalPropertyForm {
    static getNewForm(model) {
        return <a href={model.url}>
            <form className="rpForm">
                <br />
                <label className="name">{model.name}</label>
                <br /><br />

                <label className="address">{model.address}</label>
                <br /><br />

                <label className="price">{model.price}</label>
                <br />
            </form>
        </a>
    }
}

export default RentalPropertyForm;