<template>

    <div>

        <h1>Dashboard</h1>

        <span>Bem vindo ao IssueFlow</span>

    </div>

</template>

<script setup>

    import { ref } from 'vue'
    import { onMounted } from 'vue'
    import router from '../router'

    function logout() {

        localStorage.removeItem('token')

        router.push('/')
    }

    const issues = ref([])

    async function loadIssues() {

        const token = localStorage.getItem('token')

        const response = await fetch('http://localhost:5176/api/issue', {
            headers: {
                Authorization: 'Bearer ' + token
            }
        })

        const data = await response.json()

        issues.value = data
    }

    onMounted(() => {

        const token = localStorage.getItem('token')

        if (!token) {
            router.push('/')
        }

    })

</script>