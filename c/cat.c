#include <jansson.h>

int main() {
  json_t *json;
  json_error_t error;
  int i, j;

  json = json_loadf(stdin, 0, &error);

  for (i = 1; i < json_array_size(json); i++) {
    json_t *block = json_array_get(json, i);
    const char *blockType = json_string_value(json_array_get(block, 0));
    json_t *blockAttr = json_array_get(block, 1);

    for (j = 2; j < json_array_size(block); j++) {
      json_t *span = json_array_get(block, j);
      const char *spanType = json_string_value(json_array_get(span, 0));
      const char *text = json_string_value(json_array_get(span, 1));
      printf("%s", text);
    }
    printf("\n\n");
  }

  json_decref(json);

  return 0;
};
