<template>

    <div class="login">

        <h2>IssueFlow Login</h2>

        <input v-model="email" placeholder="Email">
        <input v-model="password" type="password" placeholder="Senha">

        <button @click="login">Entrar</button>

        <p v-if="error">{{ error }}</p>

    </div>

</template>

<script setup>

    import { ref } from 'vue'
    import router from '../router'

    const email = ref('')
    const password = ref('')
    const error = ref('')

    async function login() {

        error.value = ''

        const response = await fetch('http://localhost:5176/api/auth/login', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                email: email.value,
                password: password.value
            })
        })

        if (!response.ok) {
            error.value = 'Login inválido'
            return
        }

        const data = await response.json()

        if (!data.token) {
            error.value = 'Usuário ou senha incorretos'
            return
        }

        localStorage.setItem('token', data.token)

        router.push('/dashboard')
    }

</script>

<style scoped>

    .login {
        width: 320px;
        margin: 120px auto;
        display: flex;
        flex-direction: column;
        gap: 10px;
    }

    input {
        padding: 10px;
    }

    button {
        padding: 10px;
        background: #2563eb;
        color: white;
        border: none;
        cursor: pointer;
    }

</style>