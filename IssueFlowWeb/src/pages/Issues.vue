<template>
	<div>
		<h1>Issues</h1>
		<table>
			<thead>
				<tr>
					<th>ID</th>
					<th>Título</th>
				</tr>
			</thead>
			<tbody>
				<tr v-for="issue in issues" :key="issue.id">
					<td>{{ issue.id }}</td>
					<td>{{ issue.title }}</td>
				</tr>
			</tbody>
		</table>
		<div v-if="error" style="color: red; margin-top: 1rem;">
			Erro ao carregar as issues: {{ error }}
		</div>
	</div>
</template>

<script setup>

	import { ref, onMounted } from 'vue'

	const issues = ref([])
	const error = ref(null)

	async function loadIssues() {
		try {

			const response = await fetch('http://localhost:5176/api/issue/test')

			if (!response.ok) {
				throw new Error(`HTTP ${response.status}`)
			}

			issues.value = await response.json()
		} catch (err) {
			console.error('Erro ao carregar issues:', err)
			error.value = err.message
		}
	}

	onMounted(loadIssues)

</script>

<style scoped>

	table {
		border-collapse: collapse;
		width: 100%;
		margin-top: 1rem;
	}

	th, td {
		border: 1px solid #ccc;
		padding: 0.5rem;
		text-align: left;
	}

	th {
		background-color: #f5f5f5;
	}

</style>