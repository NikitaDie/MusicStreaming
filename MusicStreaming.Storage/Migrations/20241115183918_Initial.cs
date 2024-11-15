using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicStreaming.Storage.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "songs",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    artist = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    album = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    duration = table.Column<TimeSpan>(type: "interval", nullable: false),
                    genre = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("songs_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    username = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    password_hash = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("users_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "playback_history",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    song_id = table.Column<Guid>(type: "uuid", nullable: false),
                    played_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("playback_history_pkey", x => x.id);
                    table.ForeignKey(
                        name: "fk_song_id",
                        column: x => x.song_id,
                        principalTable: "songs",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "playlists",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    deleted_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("playlists_pkey", x => x.id);
                    table.ForeignKey(
                        name: "fk_user",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "playlist_songs",
                columns: table => new
                {
                    playlist_id = table.Column<Guid>(type: "uuid", nullable: false),
                    song_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_playlist_id_song_id", x => new { x.playlist_id, x.song_id });
                    table.ForeignKey(
                        name: "fk_playlist_id",
                        column: x => x.playlist_id,
                        principalTable: "playlists",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_song_id",
                        column: x => x.song_id,
                        principalTable: "songs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "user_songs",
                columns: table => new
                {
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    song_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_id_song_id", x => new { x.user_id, x.song_id });
                    table.ForeignKey(
                        name: "fk_user",
                        column: x => x.song_id,
                        principalTable: "songs",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_user_id",
                        column: x => x.user_id,
                        principalTable: "playlists",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_playback_history_song_id",
                table: "playback_history",
                column: "song_id");

            migrationBuilder.CreateIndex(
                name: "IX_playback_history_user_id",
                table: "playback_history",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_playlist_songs_song_id",
                table: "playlist_songs",
                column: "song_id");

            migrationBuilder.CreateIndex(
                name: "IX_playlists_user_id",
                table: "playlists",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_songs_song_id",
                table: "user_songs",
                column: "song_id");

            migrationBuilder.CreateIndex(
                name: "users_email_key",
                table: "users",
                column: "email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "playback_history");

            migrationBuilder.DropTable(
                name: "playlist_songs");

            migrationBuilder.DropTable(
                name: "user_songs");

            migrationBuilder.DropTable(
                name: "songs");

            migrationBuilder.DropTable(
                name: "playlists");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
