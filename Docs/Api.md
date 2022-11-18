# Buber Dinner API

- [Buber Dinner API](#buber-dinner-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
  "firstName": "Marcus",
  "lastName": "Santos",
  "email": "marcus.santos1808@hotmail.com",
  "password": "Pwd12345."
}
```

#### Register Response

```js
200 OK
```

```json
{
  "id": "c06469eb-0a97-4530-83b3-4f72a03ff9e9",
  "firstName": "Marcus",
  "lastName": "Santos",
  "email": "marcus.santos1808@hotmail.com",
  "token": "eyJhb..1233e"
}
```

### Login

#### Login Request

```json
{
  "email": "marcus.santos1808@hotmail.com",
  "password": "Pwd12345."
}
```

#### Login Response

```js
200 OK
```

```json
{
  "id": "c06469eb-0a97-4530-83b3-4f72a03ff9e9",
  "firstName": "Marcus",
  "lastName": "Santos",
  "email": "marcus.santos1808@hotmail.com",
  "token": "eyJhb..1233e"
}
```

