import React, { useState } from 'react';
import './styles.css'

interface iModel{
    Nome: string
    Endereco: string
    Telefone: string
    Email: string
    Hamburguer: string
    Shake: string
}

export const PecaJa: React.FC = () => {
    const [Nome, setNome] = useState('')
    const [Endereco, setEndereco] = useState('')
    const [Telefone, setTelefone] = useState('')
    const [Email, setEmail] = useState('')
    const [Hamburguer, setHamburguer] = useState('')
    const [Shake, setShake] = useState('')

function Pedir(): void {
    const form: iModel = {
    Nome: Nome,
    Endereco: Endereco,
    Telefone: Telefone,
    Email: Email,
    Hamburguer: Hamburguer,
    Shake: Shake
    }
    console.log(form)
    console.log("Pedido realizado!")
}
    return (
        <div>
        <h5>Pode pedir!</h5> 
        <input onChange={(e) => setNome(e.target.value)} placeholder='Nome'/>
        <input onChange={(e) => setEndereco(e.target.value)} placeholder='Endereço'/>
        <input onChange={(e) => setTelefone(e.target.value)} placeholder='Telefone'/>
        <input onChange={(e) => setEmail(e.target.value)} placeholder='Email'/>
        <select value={'1'} onChange={(e) => setHamburguer(e.target.value)}>
            <option value={'0'}>Hamburger numero 1</option>
            <option value={'1'}>Hamburger numero 2</option>
            <option value={'2'}>Hamburger numero 3</option>
        </select>
        
        <select value={Shake} onChange={(e) => setShake(e.target.value)}>
            <option value={'0'}>Shake numero 1</option>
            <option value={'1'}>Shake numero 2</option>
            <option value={'2'}>Shake numero 3</option>
        </select>

        <button onClick={Pedir}>Finalizar pedido</button>

        </div>
    );
}