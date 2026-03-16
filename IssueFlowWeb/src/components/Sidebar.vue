<template>

    <div class="sidebar" :class="{collapsed: collapsed}">

        <h2 v-if="!collapsed">IssueFlow</h2>

        <nav>
            <router-link to="/dashboard">Dashboard</router-link>
            <router-link to="/issues">Issues</router-link>
            <router-link to="/users">Users</router-link>
        </nav>

    </div>

</template>

<script setup>
    defineProps({
        collapsed:Boolean
    })
</script>

<style scoped>

    .sidebar{
        width:220px;
        height:100vh;
        background:#1f2937;
        color:white;
        padding:20px;
        transition:0.3s;
    }

    .sidebar.collapsed{
        width:70px;
    }

    nav{
        display:flex;
        flex-direction:column;
        gap:10px;
    }

    a{
        color:white;
        text-decoration:none;
    }

</style>