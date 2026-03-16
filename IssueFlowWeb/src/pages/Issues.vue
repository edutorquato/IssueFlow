<template>

	<div>

		<h1>Issues</h1>

		<table>

			<tr>
				<th>ID</th>
				<th>Título</th>
			</tr>

			<tr v-for="issue in issues" :key="issue.id">
				<td>{{ issue.id }}</td>
				<td>{{ issue.title }}</td>
			</tr>

		</table>

	</div>

</template>

<script setup>

	import { ref, onMounted } from 'vue'

	const issues = ref([])

	async function loadIssues(){

		const token = localStorage.getItem('token')

		const response = await fetch('http://localhost:5176/api/issue',{
			headers:{
				Authorization:'Bearer '+token
			}
		})

		issues.value = await response.json()

	}

	onMounted(loadIssues)

</script>