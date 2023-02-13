import React, { useState } from 'react';

interface iModel{
  Email: string
  Senha: string
}

export const Login: React.FC = () => {
  const [Email, setEmail] = useState('')
  const [Senha, setSenha] = useState('')
  const url = 'https://localhost:7039/api/Usuario/Login'
  
  function Login(): void {

    const form: iModel = {
      Email: Email,
      Senha: Senha
    }
    fetch(url, {
      body: JSON.stringify(form),
      method: "POST",
        headers: {
          "content-type": "application/json",
          // authorization: "Bearer " + localStorage.getItem("token"),
        }
      })
      .then((response) => response.text())
      .then((dados) => console.log(dados))
      .catch(function (error) {
        console.log(error);        
      });
    console.log(form)
    console.log("Logando...")
  }

  return (
    <div>
      <h1>Login</h1>
      <input type={'email'} onChange={(e) => setEmail(e.target.value)} placeholder='Email'/>
      <input type={'password'} onChange={(e) => setSenha(e.target.value)} placeholder='Senha'/>
      <button onClick={Login}>Entrar</button>
      </div>
  );
}