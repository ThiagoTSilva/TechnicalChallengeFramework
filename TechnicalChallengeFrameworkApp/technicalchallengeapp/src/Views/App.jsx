import './App.css'
import React, { Component } from "react";
import { render } from 'react-dom';
import api from '../Services/Api';


class App extends Component {
    constructor(props) {
        super(props)

        this.state = {
            number: 0,
            dividers: undefined
        }
    }

    setNumber = (value) => {
        this.setState({ number: value });
    }

    async calculateNumber(e) {
        e.preventDefault();
        let result = await api.get(`decomposeNumber/${this.state.number}`)
        this.setState({ dividers: result.data })
    }

    dividersItens(dividers) {

        let list = [];
        Object.keys(dividers.dividerNumbers).forEach(item => {
            list.push(dividers.dividerNumbers[item].dividers);
        })
        return (list)
    }

    primersItens(dividers) {

        let list = [];
        Object.keys(dividers.primeDividers).forEach(item => {
            list.push(dividers.primeDividers[item].primes);
        })

        return (list)
    }

    render() {
        const { dividers } = this.state;
        let numberItens
        let primersItens

        if (dividers !== undefined) {
            numberItens = this.dividersItens(dividers)
            primersItens = this.primersItens(dividers)
        }


        return (

            <div style={{ width: '100%' }} >

                <h4 style={{ paddingLeft: 20, paddingTop: 20 }}><span style={{ color: '#0054a5' }}>Technical Challenge</span> </h4>
                <hr />

                <div className='App'>
                    <form id="formSubmit" autoComplete="Off" onSubmit={(e) => this.calculateNumber(e)}>
                        <div className='div-submit'>
                            <label htmlFor="name" className="control-label">Digite um número: <span className="text-danger"></span></label>
                            <input className="input-submit" id="number" type="text" onChange={(e) => this.setNumber(e.target.value)} />

                            <button id="btnCalculetor" type="submit" id="number" className="btn btn-success"> Calcular </button>
                        </div>
                    </form>


                    <div className='div-submit'>
                        <label htmlFor="name" className="control-label">Números divisores: <span className="text-danger"></span></label>
                        <input
                            value={numberItens !== undefined ? numberItens : ""}
                        />
                    </div>
                    <div className='div-submit'>
                        <label htmlFor="name" className="control-label">Divisores Primos: <span className="text-danger"></span></label>
                        <input  value={primersItens !== undefined ? primersItens : ""}/>
                    </div>

                </div>
            </div>

        )

    }
}
export default App