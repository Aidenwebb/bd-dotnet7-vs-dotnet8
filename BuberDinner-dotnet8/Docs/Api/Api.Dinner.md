# Buber Dinner Api

- [Buber Dinner Api](#buber-dinner-api)
  - [Dinner](#dinner)
    - [Get Dinner](#get-dinner)
      - [Get Dinner Request](#get-dinner-request)
      - [Get Dinner Response](#get-dinner-response)
    - [List Dinners](#list-dinners)
      - [List Dinners Request](#list-dinners-request)
      - [List Dinners Response](#list-dinners-response)
    - [Create Dinner](#create-dinner)
      - [Create Dinner Request](#create-dinner-request)
      - [Create Dinner Response](#create-dinner-response)
    - [Update Dinner](#update-dinner)
      - [Update Dinner Request](#update-dinner-request)
      - [Update Dinner Response](#update-dinner-response)
    - [Delete Dinner](#delete-dinner)
      - [Delete Dinner Request](#delete-dinner-request)
      - [Delete Dinner Response](#delete-dinner-response)
    - [List Dinner Guests](#list-dinner-guests)
      - [List Dinner Guests Request](#list-dinner-guests-request)
      - [List Dinner Guests Response](#list-dinner-guests-response)
    - [Start Dinner](#start-dinner)
      - [Start Dinner Request](#start-dinner-request)
      - [Start Dinner Response](#start-dinner-response)
    - [End Dinner](#end-dinner)
      - [End Dinner Request](#end-dinner-request)
      - [End Dinner Response](#end-dinner-response)
    - [Cancel Dinner](#cancel-dinner)
      - [Cancel Dinner Request](#cancel-dinner-request)
      - [Cancel Dinner Response](#cancel-dinner-response)

## Dinner

### Get Dinner

#### Get Dinner Request

```js
GET /hosts/{hostId}/dinners/{dinnerId}
GET me/dinners/{dinnerId}
```

#### Get Dinner Response

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Pizza & Jazz",
    "description": "Join us for a night of Pizza and Jazz! After dinner we will continue the fun at the BRB bar 💪🏽🍺",
    "startDateTime": "2020-01-01T18:00:00.0000000Z",
    "endDateTime": "2020-01-01T18:00:00.0000000Z",
    "startedDateTime": "2020-01-01T18:00:00.0000000Z",
    "endedDateTime": "2020-01-01T18:00:00.0000000Z",
    "status": "Upcoming", // Upcoming, InProgress, Ended
    "maxGuests": 10,
    "isPublic": true,
    "price": {
        "amount": 18.00,
        "currency": "USD"
    },
    "menuId": "00000000-0000-0000-0000-000000000000",
    "hostId": "00000000-0000-0000-0000-000000000000",
    "ImageUrl": "https://images.unsplash.com/photo-1590947132387-155cc02f3212?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80",
    "location": {
        "name": "Dan's Pizza House",
        "address": "Bergen, Norway",
        "latitude": 60.391262,
        "longitude": 5.322054
    },
    "createdDateTime": "2019-01-01T00:00:00.000Z",
    "updatedDateTime": "2019-01-01T00:00:00.000Z"
}
```

### List Dinners

#### List Dinners Request

```js
GET /hosts/{hostId}/dinners
GET me/dinners
```

#### List Dinners Response

```json
[
    {
        "id": "00000000-0000-0000-0000-000000000000",
        "name": "Pizza & Jazz",
        "description": "Join us for a night of Pizza and Jazz! After dinner we will continue the fun at the BRB bar 💪🏽🍺",
        "startDateTime": "2020-01-01T18:00:00.0000000Z",
        "endDateTime": "2020-01-01T18:00:00.0000000Z",
        "startedDateTime": "2020-01-01T18:00:00.0000000Z",
        "endedDateTime": "2020-01-01T18:00:00.0000000Z",
        "status": "Upcoming", // Upcoming, InProgress, Ended
        "maxGuests": 10,
        "isPublic": true,
        "price": {
            "amount": 18.00,
            "currency": "USD"
        },
        "menuId": "00000000-0000-0000-0000-000000000000",
        "hostId": "00000000-0000-0000-0000-000000000000",
        "ImageUrl": "https://images.unsplash.com/photo-1590947132387-155cc02f3212?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80",
        "location": {
            "name": "Dan's Pizza House",
            "address": "Bergen, Norway",
            "latitude": 60.391262,
            "longitude": 5.322054
        },
        "createdDateTime": "2019-01-01T00:00:00.000Z",
        "updatedDateTime": "2019-01-01T00:00:00.000Z"
    }
]
```

### Create Dinner

#### Create Dinner Request

```js
POST /hosts/{hostId}/dinners
POST me/dinners
```

```json
{
    "name": "Pizza & Jazz",
    "description": "Join us for a night of Pizza and Jazz! After dinner we will continue the fun at the BRB bar 💪🏽🍺",
    "startDateTime": "2020-01-01T18:00:00.0000000Z",
    "endDateTime": "2020-01-01T18:00:00.0000000Z",
    "isPublic": true,
    "maxGuests": 10,
    "isPublic": true,
    "price": {
        "amount": 18.00,
        "currency": "USD"
    },
    "menuId": "00000000-0000-0000-0000-000000000000",
    "ImageUrl": "https://images.unsplash.com/photo-1590947132387-155cc02f3212?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80",
    "location": {
        "name": "Dan's Pizza House",
        "address": "Bergen, Norway",
        "latitude": 60.391262,
        "longitude": 5.322054
    },
}
```

#### Create Dinner Response

```js
201 Created
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Pizza & Jazz",
    "description": "Join us for a night of Pizza and Jazz! After dinner we will continue the fun at the BRB bar 💪🏽🍺",
    "startDateTime": "2020-01-01T18:00:00.0000000Z",
    "endDateTime": "2020-01-01T18:00:00.0000000Z",
    "startedDateTime": null,
    "endedDateTime": null,
    "status": "Upcoming", // Upcoming, InProgress, Ended
    "maxGuests": 10,
    "isPublic": true,
    "price": {
        "amount": 18.00,
        "currency": "USD"
    },
    "menuId": "00000000-0000-0000-0000-000000000000",
    "hostId": "00000000-0000-0000-0000-000000000000",
    "ImageUrl": "https://images.unsplash.com/photo-1590947132387-155cc02f3212?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80",
    "location": {
        "name": "Dan's Pizza House",
        "address": "Bergen, Norway",
        "latitude": 60.391262,
        "longitude": 5.322054
    },
    "createdDateTime": "2019-01-01T00:00:00.000Z",
    "updatedDateTime": "2019-01-01T00:00:00.000Z"
}
```

### Update Dinner

#### Update Dinner Request

```js
PUT /hosts/{hostId}/dinners/{dinnerId}
PUT me/dinners/{dinnerId}
```

```json
{
    "name": "Pizza & Jazz",
    "description": "Join us for a night of Pizza and Jazz! After dinner we will continue the fun at the BRB bar 💪🏽🍺",
    "startDateTime": "2020-01-01T18:00:00.0000000Z",
    "endDateTime": "2020-01-01T18:00:00.0000000Z",
    "maxGuests": 10,
    "menuId": "00000000-0000-0000-0000-000000000000",
    "ImageUrl": "https://images.unsplash.com/photo-1590947132387-155cc02f3212?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80"
}
```

#### Update Dinner Response

```js
204 No Content
```

### Delete Dinner

#### Delete Dinner Request

```js
DELETE /hosts/{hostId}/dinners/{dinnerId}
DELETE me/dinners/{dinnerId}
```

#### Delete Dinner Response

```js
204 No Content
```

### List Dinner Guests

#### List Dinner Guests Request

```js
GET /hosts/{hostId}/dinners/{dinnerId}/guests
GET me/dinners/{dinnerId}/guests
```

#### List Dinner Guests Response

```json
[
    {
        "id": "00000000-0000-0000-0000-000000000000",
        "firstName": "John",
        "lastName": "Doe",
        "profileImageUrl": "https://images.unsplash.com/photo-1590947132387-155cc02f3212?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80"
    }
]
```

### Start Dinner

#### Start Dinner Request

```js
POST /hosts/{hostId}/dinner/{dinnerId}/start
POST me/dinner/{dinnerId}/start
```

#### Start Dinner Response

```js
200 Ok
```

### End Dinner

#### End Dinner Request

```js
POST /hosts/{hostId}/dinner/{dinnerId}/end
POST me/dinner/{dinnerId}/end
```

#### End Dinner Response

```js
200 Ok
```

### Cancel Dinner

#### Cancel Dinner Request

```js
POST /hosts/{hostId}/dinner/{dinnerId}/cancel
POST me/dinner/{dinnerId}/cancel
```

#### Cancel Dinner Response

```js
200 Ok
```
