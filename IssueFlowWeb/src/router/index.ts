import { createRouter, createWebHistory } from 'vue-router'

import Login from '../pages/Login.vue'
import Dashboard from '../pages/Dashboard.vue'
import MainLayout from '../layouts/MainLayout.vue'
import Issues from '../pages/Issues.vue'

const routes = [

    {
        path: '/',
        component: Login
    },

    {
        path: '/',
        component: MainLayout,
        children: [
            {
                path: 'dashboard',
                component: Dashboard
            },
            {
                path:'issues',
                component:Issues
            }
        ]
    }

]

const router = createRouter({
    history: createWebHistory(),
    routes
})

export default router