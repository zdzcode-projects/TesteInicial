<template>
  <v-card>
    <v-toolbar color="white" flat>
      <v-btn icon light>
        <v-icon color="grey darken-2"> mdi-arrow-left </v-icon>
      </v-btn>

      <v-toolbar-title class="grey--text text--darken-4">
        Categorias
      </v-toolbar-title>

      <v-spacer></v-spacer>
    </v-toolbar>

    <v-container fluid>
      <v-form ref="form" v-model="valid" lazy-validation>
        <v-text-field
          v-model="categoria.nome"
          :min="5"
          :rules="nomeRules"
          label="Categoria"
          required
        ></v-text-field>

        <v-text-field
          v-model="categoria.descricao"
          label="Descrição"
        ></v-text-field>

        <v-btn :disabled="!valid" color="success" class="mr-4" @click="submit">
          Salvar
        </v-btn>

        <pre
          >{{ categoria }}
</pre
        >
      </v-form>
    </v-container>

    <v-footer class="mt-12"></v-footer>

    <v-data-table
      :headers="headers"
      :items="categorias"
      :items-per-page="5"
      class="elevation-1"
    ></v-data-table>
  </v-card>
</template>

<script>
export default {
  data: () => ({
    valid: true,
    categoria: {
      nome: "",
      descricao: "",
    },
    nomeRules: [
      (v) => !!v || "Nome é obrigatório",
      (v) =>
        (v && v.length > 5) || "Nome precisa de ter pelo menos 5 caracteres",
    ],

    headers: [
      {
        text: "Categoria",
        align: "start",
        sortable: false,
        value: "nome",
      },
      { text: "Descrição", value: "descricao" },
    ],
    categorias: [
      {
        nome: "Categoroia 1",
        descricao: "descrição da categoria1",
      },
    ],
  }),

  methods: {
    async submit() {
      debugger;

      try {
        var response = await this.$axios({
          method: "POST",
          url: "https://localhost:7248/Categoria",
          data: this.categoria,
        });

        debugger;


         var responseGet = await this.$axios({
          method: "GET",
          url: "https://localhost:7248/Categoria",
        });
        debugger
        this.categorias = responseGet.data;

      } catch {}
    },
  },
};
</script>

<style></style>
